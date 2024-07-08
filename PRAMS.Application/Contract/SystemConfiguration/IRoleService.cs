using FluentResults;
using PRAMS.Domain.Entities.SystemConfiguration.Dto;

namespace PRAMS.Application.Contract.SystemConfiguration
{
    public interface IRoleService
    {
        Task<Result<ICollection<AdmReportDto>>> GetRoleReports(string roleId);
        Task<Result<AdmReportDto>> CreateReportItem(AdmReportInsertDto admReportInsertDto, string user);
        Task<Result<AdmReportDto>> UpdateReportItem(AdmReportUpdateDto admReportUpdateDto, string user);
        Task<Result<AdmReportDto>> DeleteReportItem(int reportId, string user);
        Task<Result<ICollection<AdmReportsRoleDto>>> ListRolReportItems();
        Task<Result<ICollection<AdmReportsRoleDto>>> ListRolReportItemsByRol(string rolId);
        Task<Result<AdmReportsRoleDto>> CreateRolReportItem(AdmReportsRoleInsertDto admReportsRoleInsertDto, string user);
        Task<Result<AdmReportsRoleDto>> UpdateRolReportItem(AdmReportsRoleUpdateDto admReportsRoleUpdateDto, string user);
        Task<Result<AdmReportsRoleDto>> DeleteRolReportItem(int rReportRoleId, string user);

    }
}
