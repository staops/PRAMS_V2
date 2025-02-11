using PRAMS.Domain.Models.People;

namespace PRAMS.Domain.Entities.People.Dto
{
    public class PersonSmallDto
    {
        public int PersonaId { get; set; }
        public string? Titulo { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public required string Nombre { get; set; }
        public string? Inicial { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string? TelefonoCelular { get; set; }
        public ICollection<PersonasDireccionDto>? PersonasDirecciones { get; set; }

    }
}
