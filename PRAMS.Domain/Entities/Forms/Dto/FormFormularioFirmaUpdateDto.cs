namespace PRAMS.Domain.Entities.Forms.Dto
{
    public class FormFormularioFirmaUpdateDto
    {
        public int FormularioFirmasId { get; set; }
        public required int FormularioEtapaId { get; set; }
        public string? Rmo { get; set; }
        public required string NumCaso { get; set; }
        public required string UsuarioId { get; set; }
        public DateTime FechaFirma { get; set; }
        public required string Region { get; set; }
        public required string Local { get; set; }
        public string? Comentarios { get; set; }
        public bool Revertida { get; set; } = false;
        public DateTime RevertidaFecha { get; set; }
        public string? UsuarioRevertidaId { get; set; }
    }
}
