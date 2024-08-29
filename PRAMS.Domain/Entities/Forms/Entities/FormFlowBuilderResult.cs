using Newtonsoft.Json;
using PRAMS.Domain.Entities.Flujos.Dto;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PRAMS.Domain.Entities.Forms.Entities
{
    public class FormFlowBuilderResult
    {
        [JsonProperty("canContinue", Order = 1)]
        public bool CanContinue { get; set; }
        public AdmFlujoFormularioDto? AdmFlujoFormulario { get; set; }
        public AdmFlujoFormularioEtapaDto? AdmFlujoFormularioEtapa { get; set; }
        public AdmFlujoFormularioEtapaAccionDto? AdmFlujoFormularioEtapaAccion { get; set; }
        public IList<AdmFlujoFormularioEtapaAccionCampoDto>? AdmFormularioEtapaAccioneCampos { get; set; }
        public object? Errors { get; set; }
    }

    public class FormFlowBuilderObjectResult<TValue> : FormFlowBuilderResult
    {
        [JsonProperty("object", Order = 2)]
        public TValue? Object { get; set; }
    }
}
