using Newtonsoft.Json;

namespace PRAMS.Domain.Entities.SystemConfiguration.Dto
{
    public class AdmReportUpdateDto : AdmReportInsertDto
    {
        [JsonProperty("reportId", Required = Required.Always)]
        public required int ReportId { get; set; }
    }
}
