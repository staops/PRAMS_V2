using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.Flujos
{
    [Table("Adm_FlujoFormularioNotas")]
    public class AdmFlujoFormularioNota
    {
        [Key]
        public int FormularioNotaId { get; set; }
        [Required]
        public required int FormularioId { get; set; }
        [StringLength(255)]
        [Column("TX_NombreNota")]
        public string? TXNombreNota { get; set; }
        [StringLength(255)]
        [Column("TX_Descripcion")]
        public string? TXDescripcion { get; set; }
        [StringLength(200)]
        [Column("TX_Subject")]
        public string? TXSubject { get; set; }
        [StringLength(200)]
        [Column("TX_Mensaje")]
        public string? TXMensaje { get; set; }
        [Column("ID_TipoUsuario")]
        public int? TipoUsuarioId { get; set; }

        [ForeignKey("FormularioId")]
        public virtual AdmFlujoFormulario? AdmFlujoFormulario { get; set; }
    }
}
