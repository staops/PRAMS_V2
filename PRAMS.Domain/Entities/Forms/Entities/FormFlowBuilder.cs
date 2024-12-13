using Newtonsoft.Json;

namespace PRAMS.Domain.Entities.Forms.Entities
{
    public class FormFlowBuilder
    {
        [JsonProperty("formularioid", Required = Required.Always)]
        public int FormularioId { get; set; }
        [JsonProperty("formularioEtapaId", Required = Required.Always)]
        public int FormularioEtapaId { get; set; }
        [JsonProperty("formularioEtapaAccionId", Required = Required.Always)]
        public int FormularioEtapaAccionId { get; set; }
        [JsonProperty("fields", Required = Required.Always)]
        public IDictionary<string, object> Fields { get; set; } = new Dictionary<string, object>();
        [JsonProperty("formaId")]
        public int? FormaId { get; set; }
    }

    public class FormSignatureBuilder : FormFlowBuilder
    {

    }
}
