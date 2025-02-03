namespace PRAMS.Domain.Entities.Flujos.Dto
{
    public class AdmFlujoFormularioEtapaAccionCampoUpdateDto
    {
        public int FormularioEtapaAccionCampoId { get; set; }
        public int FormularioEtapaAccionId { get; set; }
        public int OrdenAccion { get; set; } = 0;
        public string CampoDB { get; set; }
        public string TablaBase { get; set; }
        public string CampoDBTipo { get; set; }
        public int CampoDBLongitud { get; set; }
        public string CampoDBIDField { get; set; }
        public string? TipoProcesoCampo { get; set; }
        public string? Resultado { get; set; }
        public string? Descripcion { get; set; }
    }
}
