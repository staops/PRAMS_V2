using Newtonsoft.Json;
using PRAMS.Domain.Entities.Flujos.Dto;
using PRAMS.Domain.Entities.Forms.Dto;

namespace PRAMS.Domain.Entities.Forms.Entities
{
    public class FormFlowBuilderResult
    {
        [JsonProperty("canContinue", Order = 1)]
        public bool CanContinue { get; set; }
        public bool IsSectionCompleted { get; set; }
        public AdmFlujoFormularioDto? AdmFlujoFormulario { get; set; }
        public AdmFlujoFormularioEtapaDto? AdmFlujoFormularioEtapa { get; set; }
        public AdmFlujoFormularioEtapaDto? AdmFlujoFormularioEtapaAnterior { get; set; }
        public AdmFlujoFormularioEtapaAccionDto? AdmFlujoFormularioEtapaAccion { get; set; }
        public IList<AdmFlujoFormularioEtapaAccionCampoDto>? AdmFormularioEtapaAccioneCampos { get; set; }
        public object? Errors { get; set; }
    }

    public class FormFlowBuilderObjectResult<TValue>
    {
        [JsonProperty("object", Order = 2)]
        public TValue? Object { get; set; }
        [JsonProperty("canContinue", Order = 1)]
        public bool CanContinue { get; set; }
        public required FormFlujoPantallaDto formFlujoPantallaInsertDto { get; set; }
    }



    public interface IFormFlowBuilderObjectResult<T>
    {
        public bool CanContinue { get; set; }
        public object? Object { get; set; }
    }
    public class FormFlowReferidoDto<T> : IFormFlowBuilderObjectResult<T> where T : class
    {
        public bool CanContinue { get; set; }
        public object? Object { get; set; }
    }

}
