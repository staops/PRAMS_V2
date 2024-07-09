using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.People
{
    [Table("Conf_Personas_Direcciones")]
    public class PersonasDirecciones
    {
        [Key]
        public int DireccionId { get; set; }

        [Required]
        public required int PersonaId { get; set; }

        [Required]
        [StringLength(75)]
        public required string TipoDireccion { get; set; }

        [Required]
        [StringLength(75)]
        public required string Direccion { get; set; }

        [StringLength(75)]
        public string? Direccion2 { get; set; }

        [StringLength(75)]
        public string? Ciudad { get; set; }

        [StringLength(75)]
        public string? Estado { get; set; }

        [StringLength(75)]
        public string? Pais { get; set; }

        [StringLength(10)]
        public string? CodigoPostal { get; set; }

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        [Required]
        [StringLength(36)]
        public required string CreateUser { get; set; }
        [Required]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public bool Activo { get; set; } = true;

        [ForeignKey("PersonaId")]
        public virtual Personas? Persona { get; set; }
    }
}
