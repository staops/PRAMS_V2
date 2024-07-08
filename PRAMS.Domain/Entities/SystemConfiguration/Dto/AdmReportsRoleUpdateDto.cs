namespace PRAMS.Domain.Entities.SystemConfiguration.Dto
{
    public class AdmReportsRoleUpdateDto
    {
        public required int ReportRoleId { get; set; }
        public required int ReportId { get; set; }
        public required string RoleId { get; set; }
    }
}
