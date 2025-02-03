namespace PRAMS.Domain.Entities.People.Dto
{
    public class PersonasDireccionUpdateDto
    {
        public int DireccionId { get; set; }
        public required string TipoDireccion { get; set; }
        public required string Direccion { get; set; }
        public string? Direccion2 { get; set; }
        public string? Ciudad { get; set; }
        public string? Estado { get; set; }
        public string? Pais { get; set; }
        public string? CodigoPostal { get; set; }
    }
}
