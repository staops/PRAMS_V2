using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.People
{
    [Table("Conf_Personas_Ingresos")]
    public class PersonasIngreso
    {
        public PersonasIngreso()
        {
            PersonasIngresosDetalle = new HashSet<PersonasIngresosDetalle>();
        }

        [Key]
        public int PersonaIngresoId { get; set; }
        [Required]
        public required int PersonaId { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public required decimal IngresoTotal { get; set; } = 0;
        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public required decimal Retencion { get; set; } = 0;
        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public required decimal Aportacion { get; set; } = 0;
        public bool Activo { get; set; } = true;

        [ForeignKey("PersonaId")]
        public virtual Persona? Persona { get; set; }
        public virtual ICollection<PersonasIngresosDetalle>? PersonasIngresosDetalle { get; set; }
    }
}
