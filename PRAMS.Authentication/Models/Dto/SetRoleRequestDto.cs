namespace PRAMS.Authentication.Models.Dto
{
    public class SetRoleRequestDto
    {
        public required string Email { get; set; }
        public required string Role { get; set; }
    }
}
