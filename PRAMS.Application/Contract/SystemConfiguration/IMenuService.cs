using FluentResults;
using PRAMS.Domain.Entities.SystemConfiguration.Dto;

namespace PRAMS.Application.Contract.SystemConfiguration
{
    public interface IMenuService
    {
        Task<Result<ICollection<AdmMenuElementDto>>> GetRoleMenu(string roleId);
        Task<Result<AdmMenuElementDto>> CreateMenuItem(AdmMenuInsertDto admMenuRoleInsertDto, string user);
        Task<Result<AdmMenuElementDto>> UpdateMenuItem(AdmMenuUpdateDto admMenuRoleInsertDto, string user);
        Task<Result<AdmMenuElementDto>> DeleteMenuItem(int menuElementId, string user);
        Task<Result<ICollection<AdmMenuRoleDto>>> ListRolMenuItems();
        Task<Result<ICollection<AdmMenuRoleDto>>> ListRolMenuItemsByRol(string rolId);
        Task<Result<AdmMenuRoleDto>> CreateRolMenuItem(AdmMenuRoleInsertDto admMenuRoleDto, string user);
        Task<Result<AdmMenuRoleDto>> UpdateRolMenuItem(AdmMenuRoleUpdateDto admMenuRoleDto, string user);
        Task<Result<AdmMenuRoleDto>> DeleteRolMenuItem(int menuElementId, string user);
    }
}
