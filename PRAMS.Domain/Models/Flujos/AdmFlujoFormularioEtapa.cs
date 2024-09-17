using PRAMS.Domain.Models.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.Flujos
{
    [Table("Adm_FlujosFormulariosEtapas")]
    public class AdmFlujoFormularioEtapa
    {
        public AdmFlujoFormularioEtapa()
        {
            AdmFlujoFormularioEtapaAcciones = new HashSet<AdmFlujoFormularioEtapaAccion>();
            FormFormularioFirmas = new HashSet<FormFormularioFirma>();
        }

        [Key]
        public required int FormularioEtapaId { get; set; }
        [Required]
        public required int FormularioId { get; set; }
        [Required]
        [StringLength(100)]
        public required string NombreEtapa { get; set; }
        [Required]
        public required int OrdenEtapa { get; set; }
        [Required]
        [StringLength(75)]
        public required string TipoEtapa { get; set; }
        [StringLength(75)]
        public string? ColorEtapa { get; set; }
        [Required]
        public required bool Completado { get; set; }
        [Required]
        public required bool Concurrencia { get; set; }
        public int? ConcurrenciaEtapa { get; set; }
        public int? NotaStartId { get; set; }
        public int? NotaEndId { get; set; }
        [Required]
        [StringLength(40)]
        public required string CreateUser { get; set; }
        [Required]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [StringLength(40)]
        public string? ModifiedUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public required bool Activo { get; set; } = true;


        [ForeignKey("NotaStartId")]
        public virtual AdmFlujoFormularioNota? AdmFlujoFormularioNotaStart { get; set; }

        [ForeignKey("NotaEndId")]
        public virtual AdmFlujoFormularioNota? AdmFlujoFormularioNotaEnd { get; set; }

        [ForeignKey("FormularioId")]
        public virtual AdmFlujoFormulario? AdmFlujoFormulario { get; set; }

        public virtual ICollection<AdmFlujoFormularioEtapaAccion> AdmFlujoFormularioEtapaAcciones { get; set; }

        public virtual ICollection<FormFormularioFirma>? FormFormularioFirmas { get; set; }
    }
}
