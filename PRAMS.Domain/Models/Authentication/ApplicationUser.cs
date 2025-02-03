using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.Authentication
{
    [Table("AspNetUsers")]
    public class ApplicationUser : IdentityUser
    {
        public required string FirstName { get; set; }
    }
}
