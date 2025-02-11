namespace PRAMS.Domain.Entities.Forms.Dto
{
    public class FormReferidoUpdateDto
    {
        public required int ReferidoId { get; set; }
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
        public string? Region { get; set; }
        public string? Local { get; set; }
        public string? Clasificacion { get; set; }
        public string? OrigenReferido { get; set; }
        public string? AsignacionReferido { get; set; }
        public int? AgenciaId { get; set; }
        public string? AgenciaSolicitadoPara { get; set; }
        public string? AgenciaSolicitud { get; set; }
        public string? SupervisorUser { get; set; }
        public DateTime? SupervisorDate { get; set; }
        public string? ReferidoOrgenId { get; set; }
        public string? TipoInvestigacion { get; set; }

        public bool Externo { get; set; }


    }
}
