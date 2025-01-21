using Microsoft.AspNetCore.Identity;

namespace PRAMS.Authentication.Models
{
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public virtual ApplicationUser User { get; set; }

        public virtual ApplicationRole Role { get; set; }
    }

    public class ApplicationRole : IdentityRole<string>
    {
        public ApplicationRole() { }

        public ApplicationRole(string roleName) : base(roleName)
        {
            Id = Guid.NewGuid().ToString();
        }

        public ICollection<ApplicationUserRole>? UserRoles { get; set; }
    }
}
