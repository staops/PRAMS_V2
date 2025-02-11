using Newtonsoft.Json;

namespace PRAMS.Domain.Entities.Forms.Dto
{
    public class FormReferidoInsertDto
    {

        public FormReferidoInsertDto() { }
        public FormReferidoInsertDto(string rmo, int? casoId, string? tipoReferido, DateTime? fechaRecibo, DateTime? horaRecibo, string? accionTomada, string? narrativaSituacion, string? referidoPor, string? relacionAdulto, string? servicioSolicitado, DateTime? servicioFechaNotificacion, string? antecedentes, string? determinacion, DateTime? determinacionFecha, string? determinacionRazon, string? region, string? local, string? clasificacion, string? origenReferido, string? asignacionReferido, int? agenciaId, string? agenciaSolicitadoPara, string? agenciaSolicitud, string? referidoOrgenId)
        {
            RMO = rmo;
            CasoId = casoId;
            TipoReferido = tipoReferido;
            FechaRecibo = fechaRecibo;
            HoraRecibo = horaRecibo;
            AccionTomada = accionTomada;
            NarrativaSituacion = narrativaSituacion;
            ReferidoPor = referidoPor;
            RelacionAdulto = relacionAdulto;
            ServicioSolicitado = servicioSolicitado;
            ServicioFechaNotificacion = servicioFechaNotificacion;
            Antecedentes = antecedentes;
            Determinacion = determinacion;
            DeterminacionFecha = determinacionFecha;
            DeterminacionRazon = determinacionRazon;
            Region = region;
            Local = local;
            Clasificacion = clasificacion;
            OrigenReferido = origenReferido;
            AsignacionReferido = asignacionReferido;
            AgenciaId = agenciaId;
            AgenciaSolicitadoPara = agenciaSolicitadoPara;
            AgenciaSolicitud = agenciaSolicitud;
            ReferidoOrgenId = referidoOrgenId;
        }

        [JsonProperty("rmo")]
        public string? RMO { get; set; }
        [JsonProperty("casoId")]
        public int? CasoId { get; set; }
        [JsonProperty("tipoReferido")]
        public string? TipoReferido { get; set; }
        [JsonProperty("fechaRecibo")]
        public DateTime? FechaRecibo { get; set; }
        [JsonProperty("horaRecibo")]
        public DateTime? HoraRecibo { get; set; }
        [JsonProperty("accionTomada")]
        public string? AccionTomada { get; set; }
        [JsonProperty("narrativaSituacion")]
        public string? NarrativaSituacion { get; set; }
        [JsonProperty("referidoPor")]
        public string? ReferidoPor { get; set; }
        [JsonProperty("relacionAdulto")]
        public string? RelacionAdulto { get; set; }
        [JsonProperty("servicioSolicitado")]
        public string? ServicioSolicitado { get; set; }
        [JsonProperty("servicioFechaNotificacion")]
        public DateTime? ServicioFechaNotificacion { get; set; }
        [JsonProperty("antecedentes")]
        public string? Antecedentes { get; set; }
        [JsonProperty("determinacion")]
        public string? Determinacion { get; set; }
        [JsonProperty("determinacionFecha")]
        public DateTime? DeterminacionFecha { get; set; }
        [JsonProperty("determinacionRazon")]
        public string? DeterminacionRazon { get; set; }
        [JsonProperty("region")]
        public string? Region { get; set; }
        [JsonProperty("local")]
        public string? Local { get; set; }
        [JsonProperty("clasificacion")]
        public string? Clasificacion { get; set; }
        [JsonProperty("origenReferido")]
        public string? OrigenReferido { get; set; }
        [JsonProperty("asignacionReferido")]
        public string? AsignacionReferido { get; set; }
        [JsonProperty("agenciaId")]
        public int? AgenciaId { get; set; }
        [JsonProperty("agenciaSolicitadoPara")]
        public string? AgenciaSolicitadoPara { get; set; }
        [JsonProperty("agenciaSolicitud")]
        public string? AgenciaSolicitud { get; set; }
        [JsonProperty("referidoOrgenId")]
        public string? ReferidoOrgenId { get; set; }
        [JsonProperty("tipoInvestigacion")]
        public string? TipoInvestigacion { get; set; }
        [JsonProperty("externo")]
        public bool Externo { get; set; }
    }
}
