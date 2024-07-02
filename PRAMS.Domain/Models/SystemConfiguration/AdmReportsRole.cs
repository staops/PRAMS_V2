using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.SystemConfiguration
{
    [Table("Adm_ReportAdminRole")]
    public class AdmReportsRole
    {
        [Key]
        public int ReportRoleId { get; set; }
        [Required]
        public int ReportId { get; set; }
        [Required]
        public required string RoleId { get; set; }
        [Required]
        public required string CreateUser { get; set; }
        [Required]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [Required]
        public bool Activo { get; set; } = true;

        [ForeignKey("ReportId")]
        public virtual AdmMenuRole? AdmMenuRole { get; set; }
    }
}
