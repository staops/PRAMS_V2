namespace PRAMS.Domain.Entities.Forms.Dto
{
    public class FormReferidoDto
    {
        public required int ReferidoId { get; set; }
        public string? RMO { get; set; }
        public int? CasoId { get; set; }
        public string? TipoReferido { get; set; }
        public DateTime? FechaRecibo { get; set; }
        public TimeSpan? HoraRecibo { get; set; }
        public string? AccionTomada { get; set; }
        public string? NarrativaSituacion { get; set; }
        public int? ReferidoPor { get; set; }
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
        public required string CreateUser { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string? ModifiedUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public required bool Activo { get; set; } = true;
    }
}
