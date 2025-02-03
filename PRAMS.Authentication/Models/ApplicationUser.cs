using Microsoft.AspNetCore.Identity;

namespace PRAMS.Authentication.Models
{
    public class ApplicationUser : IdentityUser
    {
        public required string FirstName { get; set; }
        public string? Initial { get; set; }
        public required string LastName { get; set; }
        public string? SecondLastName { get; set; }
        public string? Region { get; set; }
        public string? Local { get; set; }
        public ICollection<ApplicationUserRole> UserRoles { get; set; } = new List<ApplicationUserRole>();
    }
}
