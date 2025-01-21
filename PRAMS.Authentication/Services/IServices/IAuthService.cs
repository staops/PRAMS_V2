using FluentResults;
using PRAMS.Authentication.Models.Dto;

namespace PRAMS.Authentication.Services.IServices
{
    public interface IAuthService
    {
        Task<Result<UserDto>> RegisterUserAsync(RegistrationRequestDto registrationRequiredDto);
        Task<Result<LoginResponseDto>> LoginAsync(LoginRequestDto loginRequestDto);
        Task<Result<LoginResponseDto>> CheckToken(string token);
        Task<Result<bool>> AssignRole(string email, string roleName);
        Task<Result<bool>> AssignLocalAndRegion(string email, string local, string region);
    }
}
