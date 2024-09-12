using PRAMS.Domain.Models.Flujos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.Forms
{
    [Table("Form_FlujosPantallas")]
    public class FormFlujoPantalla
    {
        [Key]
        [Column("ID_FORM_FlujoPantalla")]
        public required int FlujoPantallaId { get; set; }

        [Required]
        [Column("ID_Formulario")]
        public required int FormularioId { get; set; }

        [Required]
        [Column("ID_Forma")]
        public required int FormaId { get; set; }

        [Required]
        public required int OrdenEtapa { get; set; }

        [Required]
        [StringLength(75)]
        public required string FlujoEtapa { get; set; }

        [Required]
        [Column("Fecha_Flujo")]
        public required DateTime FechaFlujo { get; set; } = DateTime.Now;

        [Required]
        [Column("ID_User_Flujo")]
        [StringLength(40)]
        public required string UsuarioFlujoId { get; set; }

        [StringLength(25)]
        public string? RMO { get; set; }

        [StringLength(25)]
        [Column("Numero_Caso")]
        public string? NumeroCaso { get; set; }

        [StringLength(75)]
        public string? Persona { get; set; }

        [Column("ID_User_Asigna")]
        [StringLength(40)]
        public string? UsuarioAsignaId { get; set; }

        [Column("ID_User_Asignado")]
        [StringLength(40)]
        public string? UsuarioAsignadoId { get; set; }

        [Column("Flujo_Status")]
        [StringLength(50)]
        public string? FlujoStatus { get; set; }

        [StringLength(255)]
        public string? Notas { get; set; }

        [StringLength(1500)]
        public string? Comentarios { get; set; }

        public bool EtapaCompletada { get; set; } = false;

        [StringLength(75)]
        public string? Region { get; set; }

        [StringLength(75)]
        public string? Local { get; set; }

        [ForeignKey("FormularioId")]
        virtual public AdmFlujoFormulario? AdmFlujoFormulario { get; set; }

    }
}
