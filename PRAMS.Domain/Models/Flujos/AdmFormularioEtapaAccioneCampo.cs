using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.Flujos
{
    [Table("Adm_FlujosFormulariosEtapasAccionesCampos")]
    public class AdmFormularioEtapaAccioneCampo
    {
        [Key]
        public int FormularioEtapaAccionCampoId { get; set; }
        [Required]
        public int FormularioEtapaAccionId { get; set; }
        [Required]
        public required int OrdenAccion { get; set; } = 0;
        [Required]
        [StringLength(75)]
        public required string CampoDB { get; set; }
        [Required]
        [StringLength(75)]
        public required string TablaBase { get; set; }
        [Required]
        [StringLength(75)]
        public required string CampoDBTipo { get; set; }
        [Required]
        public required int CampoDBLongitud { get; set; }
        [Required]
        [StringLength(75)]
        [Column("CampoDB_IDField")]
        public required string CampoDBIDField { get; set; }
        [StringLength(75)]
        public string? TipoProcesoCampo { get; set; }
        [StringLength(255)]
        public string? Resultado { get; set; }
        [StringLength(255)]
        public string? Descripcion { get; set; }

        [ForeignKey("FormularioEtapaAccionId")]
        public virtual AdmFlujoFormularioEtapaAccion? AdmFlujoFormularioEtapaAccion { get; set; }

    }
}
