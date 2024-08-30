namespace PRAMS.Domain.Entities.Flujos.Dto
{
    public class AdmFlujoFormularioEtapaAccionCampoInsertDto
    {
        public AdmFlujoFormularioEtapaAccionCampoInsertDto(int formularioEtapaAccionId, int ordenAccion, string campoDB, string tablaBase, string campoDBTipo, int campoDBLongitud, string campoDBIDField, string? tipoProcesoCampo, string? resultado, string? descripcion)
        {
            FormularioEtapaAccionId = formularioEtapaAccionId;
            OrdenAccion = ordenAccion;
            CampoDB = campoDB;
            TablaBase = tablaBase;
            CampoDBTipo = campoDBTipo;
            CampoDBLongitud = campoDBLongitud;
            CampoDBIDField = campoDBIDField;
            TipoProcesoCampo = tipoProcesoCampo;
            Resultado = resultado;
            Descripcion = descripcion;
        }

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
