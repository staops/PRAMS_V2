namespace PRAMS.Domain.Entities.Forms.Dto
{
    public class FormReferidoInsertDto
    {

        public FormReferidoInsertDto() { }
        public FormReferidoInsertDto(string rmo, int? casoId, string? tipoReferido, DateTime? fechaRecibo, DateTime? horaRecibo, string? accionTomada, string? narrativaSituacion, string? referidoPor, string? relacionAdulto, string? servicioSolicitado, DateTime? servicioFechaNotificacion, string? antecedentes, string? determinacion, DateTime? determinacionFecha, string? determinacionRazon, string? asignacionRegion, string? asignacionOficina, string? clasificacion, string? origenReferido, string? asignacionReferido, int? agenciaId, string? agenciaSolicitadoPara, string? agenciaSolicitud, string? referidoOrgenId)
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
            AsignacionRegion = asignacionRegion;
            AsignacionOficina = asignacionOficina;
            Clasificacion = clasificacion;
            OrigenReferido = origenReferido;
            AsignacionReferido = asignacionReferido;
            AgenciaId = agenciaId;
            AgenciaSolicitadoPara = agenciaSolicitadoPara;
            AgenciaSolicitud = agenciaSolicitud;
            ReferidoOrgenId = referidoOrgenId;
        }


        public string? RMO { get; set; }
        public int? CasoId { get; set; }
        public string? TipoReferido { get; set; }
        public DateTime? FechaRecibo { get; set; }
        public DateTime? HoraRecibo { get; set; }
        public string? AccionTomada { get; set; }
        public string? NarrativaSituacion { get; set; }
        public string? ReferidoPor { get; set; }
        public string? RelacionAdulto { get; set; }
        public string? ServicioSolicitado { get; set; }
        public DateTime? ServicioFechaNotificacion { get; set; }
        public string? Antecedentes { get; set; }
        public string? Determinacion { get; set; }
        public DateTime? DeterminacionFecha { get; set; }
        public string? DeterminacionRazon { get; set; }
        public string? AsignacionRegion { get; set; }
        public string? AsignacionOficina { get; set; }
        public string? Clasificacion { get; set; }
        public string? OrigenReferido { get; set; }
        public string? AsignacionReferido { get; set; }
        public int? AgenciaId { get; set; }
        public string? AgenciaSolicitadoPara { get; set; }
        public string? AgenciaSolicitud { get; set; }
        public string? ReferidoOrgenId { get; set; }
    }
}
