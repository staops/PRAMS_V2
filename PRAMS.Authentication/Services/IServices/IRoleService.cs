using FluentResults;
using Microsoft.AspNetCore.Identity;
using PRAMS.Authentication.Models;

namespace PRAMS.Authentication.Services.IServices
{
    public interface IRoleService
    {
        Task<Result<IList<ApplicationRole>>> GetRoles();
    }
}
