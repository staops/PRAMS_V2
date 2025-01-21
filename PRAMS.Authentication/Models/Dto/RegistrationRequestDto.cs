using System.ComponentModel.DataAnnotations;

namespace PRAMS.Authentication.Models.Dto
{
    public class RegistrationRequestDto
    {
        [Required]
        public required string Email { get; set; }
        [Required]
        public required string FirstName { get; set; }
        [Required]
        public required string Password { get; set; }
        [Required]
        public string? Role { get; set; }
        [Required]
        public required string Region { get; set; }
        [Required]
        public required string Local { get; set; }

        public string? Initial { get; set; }
        public required string LastName { get; set; }
        public string? SecondLastName { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
