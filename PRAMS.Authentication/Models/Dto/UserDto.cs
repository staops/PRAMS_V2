namespace PRAMS.Authentication.Models.Dto
{
    public class UserDto
    {
        public required string ID { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public required string Region { get; set; }
        public required string Local { get; set; }
        public required string Name { get; set; }
        public string? PhoneNumber { get; set; }
        public IList<string>? Roles { get; set; }
    }
}
