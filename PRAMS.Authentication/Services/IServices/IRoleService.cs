using FluentResults;
using Microsoft.AspNetCore.Identity;

namespace PRAMS.Authentication.Services.IServices
{
    public interface IRoleService
    {
        Task<Result<IList<IdentityRole>>> GetRoles();
    }
}
