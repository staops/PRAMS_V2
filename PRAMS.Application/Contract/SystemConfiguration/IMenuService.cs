using FluentResults;
using PRAMS.Domain.Entities.SystemConfiguration.Dto;

namespace PRAMS.Application.Contract.SystemConfiguration
{
    public interface IMenuService
    {
        Task<Result<ICollection<AdmMenuRoleDto>>> GetRoleMenu(string roleId);
    }
}
