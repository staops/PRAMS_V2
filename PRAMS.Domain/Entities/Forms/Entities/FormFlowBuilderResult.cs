using PRAMS.Domain.Entities.Flujos.Dto;

namespace PRAMS.Domain.Entities.Forms.Entities
{
    public class FormFlowBuilderResult
    {
        public AdmFlujoFormularioDto? admFlujoFormulario { get; set; }
        public AdmFlujoFormularioEtapaDto? admFlujoFormularioEtapa { get; set; }
        public AdmFlujoFormularioEtapaAccionDto? admFlujoFormularioEtapaAccion { get; set; }
        public IList<AdmFlujoFormularioEtapaAccionCampoDto>? admFormularioEtapaAccioneCampos { get; set; }
    }
}
