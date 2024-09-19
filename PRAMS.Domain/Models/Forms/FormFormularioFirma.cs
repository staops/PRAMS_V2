using PRAMS.Domain.Models.Flujos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.Forms
{
    [Table("Form_FormulariosFirmas")]
    public class FormFormularioFirma
    {
        [Key]
        [Column("ID_FormularioFirmas")]
        public int FormularioFirmasId { get; set; }

        [Required]
        [Column("ID_Formulario")]
        public required int FormularioId { get; set; }

        [Required]
        [Column("ID_FormularioEtapa")]
        public required int FormularioEtapaId { get; set; }

        [Column("ID_Forma")]
        public int? FormaId { get; set; }

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
        [StringLength(40)]
        public required string UsuarioId { get; set; }

        [StringLength(40)]
        public string? UserTypeID { get; set; }

        [Required]
        public DateTime? FechaFirma { get; set; }

        [StringLength(75)]
        public string? Region { get; set; }

        [StringLength(75)]
        public string? Local { get; set; }

        [StringLength(1000)]
        public string? Comentarios { get; set; }

        [Required]
        public bool Revertida { get; set; } = false;
        public DateTime? RevertidaFecha { get; set; }

        [StringLength(30)]
        [Column("ID_Usuario_Revierte")]
        public string? UsuarioRevierteId { get; set; }


        [ForeignKey("ID_FormularioEtapa")]
        public virtual AdmFlujoFormularioEtapa? AdmFlujoFormularioEtapa { get; set; }


    }
}
