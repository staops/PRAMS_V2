using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.Forms
{
    [Table("Form_AsignacionUsuarios")]
    public class FormAsignacionUsuarios
    {
        [Key]
        [Column("ID_AsignacionUsuario")]
        public int IdAsignacionUsuario { get; set; }
        [Column("ID_Refereido")]
        [Required]
        public int IdReferido { get; set; }
        [Column("RMO")]
        public string? Rmo { get; set; }
        [Column("Num_Caso")]
        public string? NumCaso { get; set; }
        [Column("ID_Usuario")]
        [Required]
        public required string IdUsuario { get; set; }
        [Required]
        public DateTime FechaStart { get; set; }
        public DateTime? FechaEnd { get; set; }
        public string? NivelCaso { get; set; }
        [Column("ID_Usuario_Asigna")]
        public string? IdUsuarioAsigna { get; set; }
        public DateTime? FechaAsignacion { get; set; }
        public bool PrincipalTS { get; set; } = true;
        public bool Activo { get; set; } = true;
        public string? Region { get; set; }
        public string? Local { get; set; }

        [ForeignKey("IdReferido")]
        public virtual FormReferido? FormReferidoNavigation { get; set; }
    }
}
