using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.SystemConfiguration
{
    [Table("Adm_ReportAdmin")]
    public class AdmReports
    {
        public AdmReports()
        {
            AdmReportsRoles = new HashSet<AdmReportsRole>();
        }

        [Key]
        public required int ReportId { get; set; }
        [Required]
        public required string ReportType { get; set; }
        [Required]
        public required string ReportName { get; set; }
        public string? ReportDescription { get; set; }
        [Required]
        public required string ReportLink { get; set; }
        public string? ReportParameters { get; set; }
        public int Orden { get; set; }
        [Required]
        public required string CreateUser { get; set; }
        [Required]
        public required DateTime CreateDate { get; set; } = DateTime.Now;
        public required bool Activo { get; set; } = true;

        public virtual ICollection<AdmReportsRole>? AdmReportsRoles { get; set; }
    }
}
