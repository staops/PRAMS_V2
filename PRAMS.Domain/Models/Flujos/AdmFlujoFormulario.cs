using PRAMS.Domain.Models.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.Flujos
{
    [Table("Adm_FlujosFormularios")]
    public class AdmFlujoFormulario
    {
        public AdmFlujoFormulario()
        {
            AdmFlujoFormularioEtapas = new HashSet<AdmFlujoFormularioEtapa>();
            FormFormularioFirmas = new HashSet<FormFormularioFirma>();
            FormFlujoPantallas = new HashSet<FormFlujoPantalla>();
        }

        [Key]
        public int FormularioId { get; set; }
        [Required]
        [StringLength(75)]
        public required string TipoCaso { get; set; }
        [Required]
        [StringLength(75)]
        public required string Formulario { get; set; }
        [Required]
        [StringLength(75)]
        public required int TablaBase { get; set; }
        [Required]
        [StringLength(255)]
        public required string Descripcion { get; set; }
        [Required]
        public required int OrdenFormulario { get; set; }
        [Required]
        [StringLength(75)]
        public required string NivelCaso { get; set; }
        [StringLength(255)]
        [Column("TX_Filtro")]
        public string? TXFiltro { get; set; }
        [StringLength(255)]
        [Column("TX_Filtro2")]
        public string? TXFiltro2 { get; set; }
        [StringLength(255)]
        [Column("TX_Filtro3")]
        public string? TXFiltro3 { get; set; }

        public virtual ICollection<AdmFlujoFormularioEtapa>? AdmFlujoFormularioEtapas { get; set; }

        public virtual ICollection<FormFormularioFirma>? FormFormularioFirmas { get; set; }

        public virtual ICollection<FormFlujoPantalla>? FormFlujoPantallas { get; set; }
    }
}
