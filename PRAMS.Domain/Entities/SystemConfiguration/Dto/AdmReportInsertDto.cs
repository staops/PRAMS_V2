namespace PRAMS.Domain.Entities.SystemConfiguration.Dto
{
    public class AdmReportInsertDto
    {
        public required string ReportType { get; set; }
        public required string ReportName { get; set; }
        public string? ReportDescription { get; set; }
        public required string ReportLink { get; set; }
        public string? ReportParameters { get; set; }
        public int Orden { get; set; }
    }
}
