namespace PRAMS.Domain.Entities.SystemConfiguration.Dto
{
    public class AdmReportDto
    {
        public required int ReportId { get; set; }
        public required string ReportType { get; set; }
        public required string ReportName { get; set; }
        public string? ReportDescription { get; set; }
        public required string ReportLink { get; set; }
        public string? ReportParameters { get; set; }
    }
}
