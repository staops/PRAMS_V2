namespace PRAMS.Domain.Entities.Flujos.Dto
{
    public class AdmFlujoFormularioNotaUpdateDto
    {
        public int FormularioNotaId { get; set; }
        public required int FormularioId { get; set; }
        public string? TXNombreNota { get; set; }
        public string? TXDescripcion { get; set; }
        public string? TXSubject { get; set; }
        public string? TXMensaje { get; set; }
        public int? TipoUsuarioId { get; set; }
    }
}
