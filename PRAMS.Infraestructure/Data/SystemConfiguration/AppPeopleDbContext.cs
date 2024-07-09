using Microsoft.EntityFrameworkCore;
using PRAMS.Domain.Models.People;

namespace PRAMS.Infraestructure.Data.SystemConfiguration
{
    public class AppPeopleDbContext(DbContextOptions<AppPeopleDbContext> options) : DbContext(options)
    {
        public DbSet<Personas>  personas { get; set; }
        public DbSet<PersonasIngresos> personasIngreso { get; set; }
        public DbSet<PersonasIngresosDetalle> personasIngresoDetalle { get; set; }
        public DbSet<PersonasDirecciones> personasDirecciones { get; set; }
        public DbSet<PersonasLinks> personasLinks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Personas>().HasMany(p => p.PersonasDirecciones).WithOne(d => d.Persona).HasForeignKey(d => d.PersonaId);
            modelBuilder.Entity<Personas>().HasMany(p => p.PersonasLinks).WithOne(l => l.Persona).HasForeignKey(l => l.PersonaId);
            modelBuilder.Entity<Personas>().HasOne(p => p.PersonasIngresos).WithOne(i => i.Persona).HasForeignKey<PersonasIngresos>(i => i.PersonaId);
            modelBuilder.Entity<PersonasIngresos>().HasMany(i => i.PersonasIngresosDetalle).WithOne(d => d.PersonasIngreso).HasForeignKey(d => d.PersonaIngresoId);

        }
    }
}
