using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using PRAMS.Authentication.Data;
using PRAMS.Authentication.Extensions;
using PRAMS.Authentication.Mapping;
using PRAMS.Authentication.Models;
using PRAMS.Authentication.Services;
using PRAMS.Authentication.Services.IServices;
using PRAMS.Domain.Entities.Shared;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaulConnection"));
});
builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection("ApiSettings:JwtOptions"));
// Adding Identity authentication
builder.Services
    .AddIdentity<ApplicationUser, ApplicationRole>()
    .AddRoleManager<RoleManager<ApplicationRole>>()
    .AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

IMapper mapper = MappingAuthentication.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);

// Add NewtonSoftJson support to the project to create the Swagger documentation
builder.Services.AddSwaggerGenNewtonsoftSupport();

builder.Services.AddControllers().AddNewtonsoftJson().ConfigureApiBehaviorOptions(options =>
{
    options.InvalidModelStateResponseFactory = context =>
    {
        var result = new ResponseDto<List<IError>>
        {
            IsSuccess = false,
            Message = "Invalid model",
            Result = context.ModelState.Values.SelectMany(x => x.Errors).Select(x => (IError)new Error(x.ErrorMessage)).ToList()

        };

        return new BadRequestObjectResult(result);
    };
});

builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();

builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IUserService, UserService>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(option =>
{
    option.EnableAnnotations();
    option.AddSecurityDefinition(name: JwtBearerDefaults.AuthenticationScheme, new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Description = "JWT Authorization header using the bearer scheme",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = JwtBearerDefaults.AuthenticationScheme,
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id =JwtBearerDefaults.AuthenticationScheme,
                },
            },
            new List<string>()
        }
    });
});

//Add support to logging with SERILOG
builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));

builder.AddAppAuthentication();
builder.Services.AddAuthorization();

// List of allowed origins from the appsettings.json
string[] allowedOrigins = builder.Configuration.GetSection("AllowedOrigins").Get<string[]>() ?? ["http://localhost:8080"];

//services cors
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins(allowedOrigins).AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
if (app.Environment.IsDevelopment())
{
    app.UseSwaggerUI();
}
else
{
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "PRAMS.Authentication");
        c.RoutePrefix = string.Empty;
    });
}

//Add support to logging request with SERILOG
app.UseSerilogRequestLogging();

app.UseHttpsRedirection();

app.UseCors("corsapp");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

// Apply pending migrations automatically.
//ApplyMigrations();
app.Run();

// Apply pending migrations automatically.
void ApplyMigrations()
{
    using var scope = app.Services.CreateScope();
    var _db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    if (_db.Database.GetPendingMigrations().Any())
    {
        _db.Database.Migrate();
    }
}