namespace PRAMS.Domain.Entities.Flujos.Dto
{
    public class AdmFlujoFormularioEtapaAccionInsertDto
    {
        public AdmFlujoFormularioEtapaAccionInsertDto(int formularioEtapaId, string nombreAccion, int ordenAccion, string tipoAccion, string? tipoProceso, bool completado, bool concurrencia, int? concurrenciaAccionId)
        {
            FormularioEtapaId = formularioEtapaId;
            NombreAccion = nombreAccion;
            OrdenAccion = ordenAccion;
            TipoAccion = tipoAccion;
            TipoProceso = tipoProceso;
            Completado = completado;
            Concurrencia = concurrencia;
            ConcurrenciaAccionId = concurrenciaAccionId;
        }

        public int FormularioEtapaId { get; set; }
        public string NombreAccion { get; set; }
        public int OrdenAccion { get; set; }
        public string TipoAccion { get; set; }
        public string? TipoProceso { get; set; }
        public bool Completado { get; set; } = false;
        public bool Concurrencia { get; set; } = false;
        public int? ConcurrenciaAccionId { get; set; }
    }
}
