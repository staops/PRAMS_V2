using PRAMS.Domain.Models.People;

namespace PRAMS.Domain.Entities.People.Dto
{
    public class PersonasDireccionDto
    {
        public int DireccionId { get; set; }
        public required int PersonaId { get; set; }
        public required string TipoDireccion { get; set; }
        public required string Direccion { get; set; }
        public string? Direccion2 { get; set; }
        public string? Ciudad { get; set; }
        public string? Estado { get; set; }
        public string? Pais { get; set; }
        public string? CodigoPostal { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
