namespace PRAMS.Authentication.Models.Dto
{
    public class UserDto
    {
        public UserDto() { }

        public required string ID { get; set; }
        public string? Email { get; set; }
        public required string Region { get; set; }
        public required string Local { get; set; }
        public required string Name { get; set; }
        public string? PhoneNumber { get; set; }
        public required IList<string> Roles { get; set; }
    }
}
