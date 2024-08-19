namespace PRAMS.Domain.Entities.People.Dto
{
    public class AdmFlujoFormularioNotaDto
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
