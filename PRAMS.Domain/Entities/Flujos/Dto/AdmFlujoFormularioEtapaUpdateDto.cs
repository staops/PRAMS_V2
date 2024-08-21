namespace PRAMS.Domain.Entities.Flujos.Dto
{
    public class AdmFlujoFormularioEtapaUpdateDto
    {
        public required int FormularioEtapaId { get; set; }
        public required int FormularioId { get; set; }
        public required string NombreEtapa { get; set; }
        public required int OrdenEtapa { get; set; }
        public required string TipoEtapa { get; set; }
        public string? ColorEtapa { get; set; }
        public bool Completado { get; set; }
        public bool Concurrencia { get; set; }
        public int ConcurrenciaEtapa { get; set; }
        public int? notaStartId { get; set; }
        public int? NotaEndId { get; set; }
    }
}
