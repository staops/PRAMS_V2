namespace PRAMS.Domain.Entities.Forms.Dto
{
    public class FormFlujoPantallaDto
    {
        public required int FlujoPantallaId { get; set; }
        public required int FormularioId { get; set; }
        public required int FormaId { get; set; }
        public required int OrdenFlujo { get; set; }
        public required string FlujoEtapa { get; set; }

        public required DateTime FechaFlujo { get; set; } = DateTime.Now;
        public required string UsuarioFlujoId { get; set; }
        public string? RMO { get; set; }
        public string? NumeroCaso { get; set; }
        public string? Persona { get; set; }
        public string? UsuarioAsignaId { get; set; }
        public string? UsuarioAsignadoId { get; set; }
        public string? FlujoStatus { get; set; }
        public string? Notas { get; set; }
        public string? Comentarios { get; set; }
        public bool Procesado { get; set; } = false;
        public string? Region { get; set; }
        public string? Local { get; set; }
    }
}
