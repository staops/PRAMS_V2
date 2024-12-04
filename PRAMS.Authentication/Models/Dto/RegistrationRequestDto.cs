namespace PRAMS.Authentication.Models.Dto
{
    public class RegistrationRequestDto
    {
        public required string Email { get; set; }
        public required string FirstName { get; set; }
        public string? Initial { get; set; }
        public required string LastName { get; set; }
        public string? SecondLastName { get; set; }
        public string? PhoneNumber { get; set; }
        public required string Password { get; set; }
        public string? Role { get; set; }
    }
}
