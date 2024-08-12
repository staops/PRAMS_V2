using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.Flujos
{
    [Table("Adm_FlujoPantallaUser")]
    public class AdmFlujoPantallaUser
    {
        [Key]
        public required int FlujoUserID { get; set; }
        [Required]
        public required int FormularioEtapaId { get; set; }
        [Required]
        public required int Prioridad { get; set; }
        [StringLength(75)]
        public string? UserType { get; set; }
        [StringLength(75)]
        public string? GroupType { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public bool Activo { get; set; } = true;

        [ForeignKey("FormularioEtapaId")]
        public virtual AdmFlujoFormularioEtapa? AdmFlujoFormularioEtapa { get; set; }

    }
}
