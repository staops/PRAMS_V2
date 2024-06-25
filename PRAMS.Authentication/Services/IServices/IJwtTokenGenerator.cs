using PRAMS.Authentication.Models;

namespace PRAMS.Authentication.Services.IServices
{
    public interface IJwtTokenGenerator
    {
        string CreateToken(ApplicationUser applicationUser, IEnumerable<string> roles);
        string? ValidateToken(string token);
    }
}
