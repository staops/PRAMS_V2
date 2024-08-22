using PRAMS.Domain.Models.Flujos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.Forms
{
    [Table("Form_FormulariosFirmas")]
    public class FormFormularioFirma
    {
        [Key]
        public int FormularioFirmasId { get; set; }

        [Required]
        public required int FormularioEtapaId { get; set; }

        [Required]
        [Column("RMO")]
        [StringLength(20)]
        public string? Rmo { get; set; }

        [Required]
        [Column("Num_Caso")]
        [StringLength(20)]
        public required string NumCaso { get; set; }

        [Required]
        [Column("ID_Usuario")]
        [StringLength(20)]
        public required string UsuarioId { get; set; }

        [Required]
        public DateTime FechaFirma { get; set; }

        [Required]
        [StringLength(75)]
        public required string Region { get; set; }

        [Required]
        [StringLength(75)]
        public required string Local { get; set; }


        [StringLength(1000)]
        public string? Comentarios { get; set; }

        [Required]
        public bool Revertida { get; set; } = false;
        public DateTime RevertidaFecha { get; set; }

        [StringLength(30)]
        [Column("ID_Usuario_Revierte")]
        public string? UsuarioRevertidaId { get; set; }


        [ForeignKey("FormularioEtapaId")]
        public virtual AdmFlujoFormularioEtapa? AdmFlujoFormularioEtapa { get; set; }


    }
}
