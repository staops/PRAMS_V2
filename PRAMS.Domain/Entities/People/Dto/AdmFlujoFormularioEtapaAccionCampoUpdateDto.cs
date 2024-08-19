namespace PRAMS.Domain.Entities.People.Dto
{
    public class AdmFlujoFormularioEtapaAccionCampoUpdateDto
    {
        public int FormularioEtapaAccionCampoId { get; set; }
        public int FormularioEtapaAccionId { get; set; }
        public required int OrdenAccion { get; set; } = 0;
        public required string CampoDB { get; set; }
        public required string TablaBase { get; set; }
        public required string CampoDBTipo { get; set; }
        public required string CampoDBLongitud { get; set; }
        public required string CampoDBIDField { get; set; }
        public string? TipoProcesoCampo { get; set; }
        public string? Resultado { get; set; }
    }
}
