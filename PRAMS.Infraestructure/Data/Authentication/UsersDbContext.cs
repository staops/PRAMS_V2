using Microsoft.EntityFrameworkCore;
using PRAMS.Domain.Models.Authentication;

namespace PRAMS.Infraestructure.Data.Authentication
{
    public class UsersDbContext(DbContextOptions<UsersDbContext> options) : DbContext(options)
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
