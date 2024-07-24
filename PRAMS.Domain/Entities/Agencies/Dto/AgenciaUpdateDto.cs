namespace PRAMS.Domain.Entities.Agencies.Dto
{
    public class AgenciaUpdateDto
    {
        public int AgenciaId { get; set; }
        public required string TipoAgencia { get; set; }
        public required string NombreAgencia { get; set; }
        public required string Region { get; set; }
        public string? Direccion1 { get; set; }
        public string? Direccion2 { get; set; }
        public string? Ciudad { get; set; }
        public string? Estado { get; set; }
        public string? Pais { get; set; }
        public string? ZipCode { get; set; }
        public string? PostalDireccion1 { get; set; }
        public string? PostalDireccion2 { get; set; }
        public string? PostalCiudad { get; set; }
        public string? PostalEstado { get; set; }
        public string? PostalPais { get; set; }
        public string? PostalZipCode { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string? PersonaContacto { get; set; }
        public string? EmailContacto { get; set; }
    }
}
