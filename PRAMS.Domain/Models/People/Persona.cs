using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.People
{
    [Table("Conf_Personas")]
    public class Persona
    {
        public Persona()
        {
            PersonasDirecciones = new HashSet<PersonasDireccion>();
            PersonasLinks = new HashSet<PersonasLink>();
        }

        [Key]
        public int PersonaId { get; set; }
        [StringLength(10)]
        public string? SeguroSocial { get; set; }
        [StringLength(75)]
        public string? Titulo { get; set; }
        [StringLength(75)]
        public string? ApellidoPaterno { get; set; }
        [StringLength(75)]
        public string? ApellidoMaterno { get; set; }
        [Required]
        [StringLength(50)]
        public required string Nombre { get; set; }
        [StringLength(10)]
        public string? Inicial { get; set; }
        [Required]
        [StringLength(50)]
        public required string Genero { get; set; }
        [Required]
        [StringLength(50)]
        public required string Raza { get; set; }
        [StringLength(75)]
        [Required]
        public required string Etnia { get; set; }
        [StringLength(75)]
        [Required]
        public required string Ocupacion { get; set; }
        [StringLength(50)]
        public string? EstadoCivil { get; set; }
        [Required]
        [StringLength(50)]
        public required string Escolaridad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [Required]
        [StringLength(75)]
        public required string LugarNacePueplo { get; set; }
        [Required]
        [StringLength(75)]
        public required string LugarNaceEstado { get; set; }
        [Required]
        [StringLength(75)]
        public required string LugarNacePais { get; set; }
        [StringLength(15)]
        public string? TelefonoResidencia { get; set; }
        [StringLength(15)]
        public string? TelefonoCelular { get; set; }
        [StringLength(15)]
        public string? TelefonoFamiliar { get; set; }
        [StringLength(75)]
        public string? Discapacidad { get; set; }
        [StringLength(255)]
        public string? Impedimentos { get; set; }
        public bool PretVeterano { get; set; }
        [Required]
        [StringLength(75)]
        public required string GradAcademico { get; set; }
        [Required]
        [StringLength(75)]
        public required string Religion { get; set; }
        [StringLength(80)]
        public string? Email { get; set; }
        [Required]
        [StringLength(36)]
        public required string CreateUser { get; set; }
        [Required]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [StringLength(36)]
        public string? ModifiedUser { get; set; }
        public DateTime? ModifiedDate { get; set; } = DateTime.Now;
        public bool Merged { get; set; } = false;
        public DateTime? MergedDate { get; set; }
        [StringLength(36)]
        public string? MergedUser { get; set; }
        public int? MergedPersonId { get; set; }

        public virtual ICollection<PersonasDireccion>? PersonasDirecciones { get; set; }
        public virtual ICollection<PersonasLink>? PersonasLinks { get; set; }
        public virtual PersonasIngreso? PersonasIngresos { get; set; }

    }
}
