namespace PRAMS.Authentication.Models.Dto
{
    public class SetLocalAndRegionRequestDto
    {
        public required string Email { get; set; }
        public required string Region { get; set; }
        public required string Local { get; set; }
    }
}
