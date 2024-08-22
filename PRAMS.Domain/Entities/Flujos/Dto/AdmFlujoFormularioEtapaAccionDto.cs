namespace PRAMS.Domain.Entities.Flujos.Dto
{
    public class AdmFlujoFormularioEtapaAccionDto
    {
        public int FormularioEtapaAccionId { get; set; }
        public required int FormularioEtapaId { get; set; }
        public required string NombreAccion { get; set; }
        public required int OrdenAccion { get; set; }
        public required string TipoAccion { get; set; }
        public string? TipoProceso { get; set; }
        public required bool Completado { get; set; } = false;
        public required bool Concurrencia { get; set; } = false;
        public required int ConcurrenciaAccionId { get; set; }
    }
}
