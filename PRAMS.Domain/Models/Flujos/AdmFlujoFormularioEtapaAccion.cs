using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.Flujos
{
    [Table("Adm_FlujosFormulariosEtapasAcciones")]
    public class AdmFlujoFormularioEtapaAccion
    {
        public AdmFlujoFormularioEtapaAccion()
        {
            AdmFormularioEtapaAccioneCampos = new HashSet<AdmFormularioEtapaAccioneCampo>();
        }

        [Key]
        public int FormularioEtapaAccionId { get; set; }
        [Required]
        public required int FormularioEtapaId { get; set; }
        [Required]
        [StringLength(100)]
        public required string NombreAccion { get; set; }
        [Required]
        public required int OrdenAccion { get; set; }
        [Required]
        [StringLength(75)]
        public required string TipoAccion { get; set; }
        [StringLength(75)]
        public string? TipoProceso { get; set; }
        [Required]
        public required bool Completado { get; set; } = false;
        [Required]
        public required bool Concurrencia { get; set; } = false;
        [Required]
        public required int ConcurrenciaAccionId { get; set; }
        [Required]
        [StringLength(40)]
        public required string CreateUser { get; set; }
        [Required]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [StringLength(40)]
        public string? ModifiedUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public required bool Activo { get; set; } = true;

        [ForeignKey("FormularioEtapaId")]
        public virtual AdmFlujoFormularioEtapa? AdmFlujoFormularioEtapa { get; set; }

        public virtual ICollection<AdmFormularioEtapaAccioneCampo>? AdmFormularioEtapaAccioneCampos { get; set; }
    }
}
