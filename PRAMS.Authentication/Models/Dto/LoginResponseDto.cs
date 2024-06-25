namespace PRAMS.Authentication.Models.Dto
{
    public class LoginResponseDto
    {
        public UserDto? User { get; set; }
        public required string Token { get; set; }
    }
}
