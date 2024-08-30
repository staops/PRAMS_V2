namespace PRAMS.Domain.Entities.Flujos.Dto
{
    public class AdmFlujoFormularioNotaInsertDto
    {
        public AdmFlujoFormularioNotaInsertDto(int formularioId, string? tXNombreNota, string? tXDescripcion, string? tXSubject, string? tXMensaje, int? tipoUsuarioId)
        {
            FormularioId = formularioId;
            TXNombreNota = tXNombreNota;
            TXDescripcion = tXDescripcion;
            TXSubject = tXSubject;
            TXMensaje = tXMensaje;
            TipoUsuarioId = tipoUsuarioId;
        }

        public int FormularioId { get; set; }
        public string? TXNombreNota { get; set; }
        public string? TXDescripcion { get; set; }
        public string? TXSubject { get; set; }
        public string? TXMensaje { get; set; }
        public int? TipoUsuarioId { get; set; }
    }
}
