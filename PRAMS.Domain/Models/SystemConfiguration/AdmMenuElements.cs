using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.SystemConfiguration
{
    [Table("Adm_MenuElements")]
    public class AdmMenuElements
    {
        public AdmMenuElements()
        {
            AdmMenuRoles = new HashSet<AdmMenuRole>();
            AdmMenuChildElements = new HashSet<AdmMenuElements>();
        }

        [Key]
        public int MenuElementId { get; set; }
        [Required]
        public required string Nombre { get; set; }
        public string? Controlador { get; set; }
        public string? Accion { get; set; }
        public string? Icono { get; set; }
        public int? MenuElementParentId { get; set; }
        public int Orden { get; set; }
        [Required]
        public required string CreateUser { get; set; }
        [Required]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public bool Activo { get; set; } = true;

        public virtual ICollection<AdmMenuRole>? AdmMenuRoles { get; set; }

        [ForeignKey("MenuElementParentId")]
        public virtual ICollection<AdmMenuElements>? AdmMenuChildElements { get; set; }

    }
}
