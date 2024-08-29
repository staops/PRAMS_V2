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
        [JsonProperty("Fields", Required = Required.Always)]
        public IDictionary<string, object> Fields { get; set; } = new Dictionary<string, object>();
        public int? Id { get; set; }
    }
}
