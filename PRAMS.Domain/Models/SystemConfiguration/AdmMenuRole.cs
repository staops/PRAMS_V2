using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.SystemConfiguration
{
    [Table("Adm_MenuRole")]
    public class AdmMenuRole
    {
        [Key]
        public int MenuRoleId { get; set; }
        [Required]
        public int MenuElementId { get; set; }
        [Required]
        public required string RoleId { get; set; }
        [Required]
        public required string CreateUser { get; set; }
        [Required]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [Required]
        public bool Activo { get; set; } = true;

        [ForeignKey("MenuElementId")]
        public virtual AdmMenuElements? AdmMenuElement { get; set; }

    }
}
