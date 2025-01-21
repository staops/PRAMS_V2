using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PRAMS.Authentication.Models;

namespace PRAMS.Authentication.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string, IdentityUserClaim<string>,
    ApplicationUserRole, IdentityUserLogin<string>,
    IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ApplicationUserRole> ApplicationUserRoles { get; set; }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });

            modelBuilder.Entity<ApplicationRole>(role =>
            {
                role.HasMany(r => r.UserRoles)
                    .WithOne(ur => ur.Role)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();
            });

            modelBuilder.Entity<ApplicationUser>(user =>
            {
                user.HasMany(u => u.UserRoles)
                    .WithOne(ur => ur.User)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });


            PopulateRoles(modelBuilder);
        }


        private static void PopulateRoles(ModelBuilder modelBuilder)
        {
            IList<string> initialRoles = [
                "SU",
                "Administrador Auxiliar",
                "Oficial Administrativo",
                "Supervisor Regional",
                "Supervisor de oficina local",
                "Trabajador Social",
                "Director Regional",
                "Director Asociado",
                "Tecnico de Servicios a la Familia",
                "Administrador",
                "Sub-Administrador",
                "Especialista Trabajador Social",
                "Asistente de Servicio",
                "Supervisor UIE",
                "Investigadores UIE",
                "Director de Programa"
            ];

            foreach (var role in initialRoles)
            {
                modelBuilder.Entity<ApplicationRole>().HasData(new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = role,
                    NormalizedName = role.ToUpper()
                });
            }

            IList<ApplicationUser> defaultUsers = [
                new ApplicationUser
                {
                    Id = "118fb076-affa-4fda-8617-e6c39b7e53c2",
                    FirstName = "Admin",
                    LastName = "User",
                    SecondLastName = "One",
                    UserName = "admin1@sta.com",
                    NormalizedUserName = "ADMIN1@STA.COM",
                    Email = "admin1@sta.com",
                    NormalizedEmail = "ADMIN1@STA.COM",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAIAAYagAAAAEL8h+yY/r8Lhawk8du3a2+xAEv/sDCq9Lneg2HaUG7fJfAGWyfldFGmSDIOSZnst+w==",
                    SecurityStamp = "SMJSAWT2M63D7BYXQ7R2E3AA2GILPLBC",
                    ConcurrencyStamp = "e5a499d0-52da-42e4-aa60-06170e7c5000",
                    PhoneNumber = "7875555555",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = true,
                    AccessFailedCount = 0
                },
                new ApplicationUser
                {
                    Id = "b4cbb14e-bb75-4143-b530-ec5d8bad55f7",
                    FirstName = "Admin",
                    LastName = "User",
                    SecondLastName = "Two",
                    UserName = "admin@sta.com",
                    NormalizedUserName = "ADMIN@STA.COM",
                    Email = "admin@sta.com",
                    NormalizedEmail = "ADMIN@STA.COM",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAIAAYagAAAAEL8h+yY/r8Lhawk8du3a2+xAEv/sDCq9Lneg2HaUG7fJfAGWyfldFGmSDIOSZnst+w==",
                    SecurityStamp = "SMJSAWT2M63D7BYXQ7R2E3AA2GILPLBC",
                    ConcurrencyStamp = "e5a499d0-52da-42e4-aa60-06170e7c5000",
                    PhoneNumber = "7875555555",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = true,
                    AccessFailedCount = 0
                },
                new ApplicationUser
                {
                    Id = "03334448-73b4-438f-8fdf-784dbab58150",
                    FirstName = "Dummy",
                    LastName = "User",
                    SecondLastName = "One",
                    UserName = "dummy@dummy.com",
                    NormalizedUserName = "DUMMY@DUMMY.COM",
                    Email = "dummy@dummy.com",
                    NormalizedEmail = "ADMIN@DUMMY.COM",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAIAAYagAAAAEL8h+yY/r8Lhawk8du3a4+xAEv/sDCq9Lneg2HaUG7fJfAGWyfldFGmSDIOSZnst+w==",
                    SecurityStamp = "SMJSAWT2M63D7BYXQ7R2E3AA2GILPLBC",
                    ConcurrencyStamp = "e5a499d0-52da-42e4-aa60-06170e7c5000",
                    PhoneNumber = "7875555555",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = true,
                    AccessFailedCount = 0
                },
                                new ApplicationUser
                {
                    Id = "69e6dd63-c624-4c4a-8bf4-c910148367ad",
                    FirstName = "Dummy",
                    LastName = "User",
                    SecondLastName = "Two",
                    UserName = "dummy2@dummy.com",
                    NormalizedUserName = "DUMMY2@DUMMY.COM",
                    Email = "dummy2@dummy.com",
                    NormalizedEmail = "ADMIN2@DUMMY.COM",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAIAAYagAAAAEL8h+yY/r8Lhawk8du3a3+xAEv/sDCq9Lneg2HaUG7fJfAGWyfldFGmSDIOSZnst+w==",
                    SecurityStamp = "SMJSAWT2M63D7BYXQ7R2E3AA2GILPLBC",
                    ConcurrencyStamp = "e5a499d0-52da-42e4-aa60-06170e7c5000",
                    PhoneNumber = "7875555555",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = true,
                    AccessFailedCount = 0
                },
            ];

            modelBuilder.Entity<ApplicationUser>().HasData(defaultUsers);

        }
    }
}
