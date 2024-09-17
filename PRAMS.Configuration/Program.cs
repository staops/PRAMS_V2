using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using PRAMS.Application.Contract.Flujos;
using PRAMS.Application.Contract.Forms;
using PRAMS.Application.Contract.SystemConfiguration;
using PRAMS.Configuration.Extensions;
using PRAMS.Infraestructure.Data.SystemConfiguration;
using PRAMS.Infraestructure.Mapping.SystemConfiguration;
using PRAMS.Infraestructure.Services.Flujos;
using PRAMS.Infraestructure.Services.Forms;
using PRAMS.Infraestructure.Services.SystemConfiguration;
using Serilog;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppConfigDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("PRAMSConfigurationConnection"), b => b.MigrationsAssembly("PRAMS.Configuration"));
    options.LogTo(l => Console.WriteLine(l), LogLevel.Information);
});
IMapper mapper = MappingConfiguration.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);


builder.Services.AddControllers().AddNewtonsoftJson();

builder.Services.AddScoped<ICatalogsService>(x =>
{
    var dbContext = x.GetRequiredService<AppConfigDbContext>();
    var logger = x.GetRequiredService<ILogger<ICatalogsService>>();
    return new CatalogsService(dbContext, mapper, logger);
});

builder.Services.AddScoped<IMenuService>(x =>
{
    var dbContext = x.GetRequiredService<AppConfigDbContext>();
    var logger = x.GetRequiredService<ILogger<IMenuService>>();
    return new MenuService(dbContext, mapper, logger);
});

builder.Services.AddScoped<IRoleService>(x =>
{
    var dbContext = x.GetRequiredService<AppConfigDbContext>();
    var logger = x.GetRequiredService<ILogger<IMenuService>>();
    return new RoleService(dbContext, mapper, logger);
});

builder.Services.AddScoped<IFlujosFormulariosService>(x =>
{
    var dbContext = x.GetRequiredService<AppConfigDbContext>();
    var logger = x.GetRequiredService<ILogger<IFlujosFormulariosService>>();
    return new FlujosFormulariosService(dbContext, mapper, logger);
});

builder.Services.AddScoped<IFlujosFormulariosEtapasService>(x =>
{
    var dbContext = x.GetRequiredService<AppConfigDbContext>();
    var logger = x.GetRequiredService<ILogger<IFlujosFormulariosEtapasService>>();
    return new FlujosFormulariosEtapasService(dbContext, mapper, logger);
});

builder.Services.AddScoped<IFlujoFormularioNotasService>(x =>
{
    var dbContext = x.GetRequiredService<AppConfigDbContext>();
    var logger = x.GetRequiredService<ILogger<IFlujoFormularioNotasService>>();
    return new FlujoFormularioNotasService(dbContext, mapper, logger);
});

builder.Services.AddScoped<IFlujosFormulariosEtapasAccionesService>(x =>
{
    var dbContext = x.GetRequiredService<AppConfigDbContext>();
    var logger = x.GetRequiredService<ILogger<IFlujosFormulariosEtapasAccionesService>>();
    return new FlujosFormulariosEtapasAccionesService(dbContext, mapper, logger);
});

builder.Services.AddScoped<IFlujosFormulariosEtapasAccionesCamposService>(x =>
{
    var dbContext = x.GetRequiredService<AppConfigDbContext>();
    var logger = x.GetRequiredService<ILogger<IFlujosFormulariosEtapasAccionesCamposService>>();
    return new FlujosFormulariosEtapasAccionesCamposService(dbContext, mapper, logger);
});

builder.Services.AddScoped<IFlujosPantallasService>(x =>
{
    var dbContext = x.GetRequiredService<AppConfigDbContext>();
    var logger = x.GetRequiredService<ILogger<IFlujosPantallasService>>();
    return new FlujosPantallasService(dbContext, mapper, logger);
});

builder.Services.AddScoped<IFormulariosFirmasService>(x =>
{
    var dbContext = x.GetRequiredService<AppConfigDbContext>();
    var logger = x.GetRequiredService<ILogger<IFormulariosFirmasService>>();
    return new FormulariosFirmasService(dbContext, mapper, logger);
});

builder.Services.AddScoped<IFlujoPantallaUserService>(x =>
{
    var dbContext = x.GetRequiredService<AppConfigDbContext>();
    var logger = x.GetRequiredService<ILogger<IFlujoPantallaUserService>>();
    return new FlujoPantallaUserService(dbContext, mapper, logger);
});

builder.Services.AddScoped<IFormFlowBuilderService>(x =>
{
    var dbContext = x.GetRequiredService<AppConfigDbContext>();
    var logger = x.GetRequiredService<ILogger<IFormFlowBuilderService>>();
    var formReferidoService = x.GetRequiredService<IFormReferidoService>();
    var flujosPantallasService = x.GetRequiredService<IFlujosPantallasService>();
    var formulariosFirmasService = x.GetRequiredService<IFormulariosFirmasService>();
    return new FormFlowBuilderService(dbContext, mapper, logger, formReferidoService, flujosPantallasService, formulariosFirmasService);
});

builder.Services.AddScoped<IFormReferidoService>(x =>
{
    var dbContext = x.GetRequiredService<AppConfigDbContext>();
    var logger = x.GetRequiredService<ILogger<IFormReferidoService>>();
    return new FormReferidoService(dbContext, mapper, logger);
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(option =>
{
    option.EnableAnnotations();
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "PRAMS.Configuration", Version = "v1" });

    // Set the comments path for the Swagger JSON and UI.
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    option.IncludeXmlComments(xmlPath);

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

//services cors
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("http://localhost:8100", "http://localhost:8080").AllowAnyMethod().AllowAnyHeader();
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
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "PRAMS.Configuration");
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
ApplyMigrations();

app.Run();

// Apply pending migrations automatically.
void ApplyMigrations()
{
    using var scope = app.Services.CreateScope();
    var _db = scope.ServiceProvider.GetRequiredService<AppConfigDbContext>();
    if (_db.Database.GetPendingMigrations().Any())
    {
        _db.Database.Migrate();
    }
}
