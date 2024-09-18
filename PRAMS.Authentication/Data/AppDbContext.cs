using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PRAMS.Authentication.Models;

namespace PRAMS.Authentication.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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
                modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = role,
                    NormalizedName = role.ToUpper()
                });
            }
        }
    }
}
