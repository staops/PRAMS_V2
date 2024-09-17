using FluentResults;

namespace PRAMS.Authentication.Services.IServices
{
    public interface IRoleService
    {
        Task<Result<IList<string>>> GetRoles();
    }
}
