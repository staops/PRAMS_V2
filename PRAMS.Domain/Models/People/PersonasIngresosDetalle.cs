using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.People
{
    [Table("Conf_Personas_Ingresos_Detalle")]
    public class PersonasIngresosDetalle
    {
        [Key]
        public int PersonaIngresoDetalleId { get; set; }
        [Required]
        public required int PersonaIngresoId { get; set; }
        [Required]
        [StringLength(75)]
        public required string TipoIngreso { get; set; }
        [StringLength(75)]
        public string? Ingresos { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public required decimal Cantidad { get; set; } = 0;
        [StringLength(200)]
        public string? Comentario { get; set; }

        [ForeignKey("PersonaIngresoId")]
        public virtual PersonasIngreso? PersonasIngreso { get; set; }
    }
}
