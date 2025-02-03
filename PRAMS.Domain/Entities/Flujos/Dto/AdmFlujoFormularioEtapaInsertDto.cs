namespace PRAMS.Domain.Entities.Flujos.Dto
{
    public class AdmFlujoFormularioEtapaInsertDto
    {
        public AdmFlujoFormularioEtapaInsertDto(int formularioId, string nombreEtapa, int ordenEtapa, string tipoEtapa, string? colorEtapa, bool completado, bool concurrencia, int? concurrenciaEtapa, int? notaStartId, int? notaEndId)
        {
            FormularioId = formularioId;
            NombreEtapa = nombreEtapa;
            OrdenEtapa = ordenEtapa;
            TipoEtapa = tipoEtapa;
            ColorEtapa = colorEtapa;
            Completado = completado;
            Concurrencia = concurrencia;
            ConcurrenciaEtapa = concurrenciaEtapa;
            NotaStartId = notaStartId;
            NotaEndId = notaEndId;
        }

        public int FormularioId { get; set; }
        public string NombreEtapa { get; set; }
        public int OrdenEtapa { get; set; }
        public string TipoEtapa { get; set; }
        public string? ColorEtapa { get; set; }
        public bool Completado { get; set; }
        public bool Concurrencia { get; set; }
        public int? ConcurrenciaEtapa { get; set; }
        public int? NotaStartId { get; set; }
        public int? NotaEndId { get; set; }
    }
}
