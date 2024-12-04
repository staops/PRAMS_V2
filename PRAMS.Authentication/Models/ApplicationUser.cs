using Microsoft.AspNetCore.Identity;

namespace PRAMS.Authentication.Models
{
    public class ApplicationUser : IdentityUser
    {
        public required string FirstName { get; set; }
        public string? Initial { get; set; }
        public required string LastName { get; set; }
        public string? SecondLastName { get; set; }
    }
}
