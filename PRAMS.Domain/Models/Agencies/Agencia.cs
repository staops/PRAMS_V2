using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.Agencies
{
    [Table("Conf_Agencias")]
    public class Agencia
    {
        [Key]
        public int AgenciaId { get; set; }
        [Required]
        [StringLength(75)]
        public required string TipoAgencia { get; set; }
        [Required]
        [StringLength(255)]
        public required string NombreAgencia { get; set; }
        [Required]
        [StringLength(75)]
        public required string Region { get; set; }
        [StringLength(75)]
        public string? Direccion1 { get; set; }
        [StringLength(75)]
        public string? Direccion2 { get; set; }
        [StringLength(75)]
        public string? Ciudad { get; set; }
        [StringLength(75)]
        public string? Estado { get; set; }
        [StringLength(75)]
        public string? Pais { get; set; }
        [StringLength(10)]
        public string? ZipCode { get; set; }
        [StringLength(75)]
        public string? PostalDireccion1 { get; set; }
        [StringLength(75)]
        public string? PostalDireccion2 { get; set; }
        [StringLength(75)]
        public string? PostalCiudad { get; set; }
        [StringLength(75)]
        public string? PostalEstado { get; set; }
        [StringLength(75)]
        public string? PostalPais { get; set; }
        [StringLength(10)]
        public string? PostalZipCode { get; set; }
        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }
        [StringLength(125)]
        public string? PersonaContacto { get; set; }
        [StringLength(100)]
        public string? EmailContacto { get; set; }
        public required string CreateUser { get; set; }
        [Required]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool Activo { get; set; } = true;

    }
}
