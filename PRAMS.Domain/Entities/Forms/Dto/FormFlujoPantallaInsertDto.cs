﻿namespace PRAMS.Domain.Entities.Forms.Dto
{
    public class FormFlujoPantallaInsertDto
    {
        public required int FormularioId { get; set; }
        public required int FormaId { get; set; }
        public required int OrdenEtapa { get; set; }
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
        public bool EtapaCompletada { get; set; } = false;
        public string? Region { get; set; }
        public string? Local { get; set; }
    }
}
