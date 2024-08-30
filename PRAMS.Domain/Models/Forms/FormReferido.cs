using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.Forms
{
    [Table("Form_Referridos")]
    public class FormReferido
    {
        [Key]
        public required int ReferidoId { get; set; }
        [StringLength(25)]
        public string? RMO { get; set; }
        public int? CasoId { get; set; }
        [StringLength(75)]
        public string? TipoReferido { get; set; }
        public DateTime? FechaRecibo { get; set; }
        public DateTime? HoraRecibo { get; set; }
        [StringLength(50)]
        [Column("Accion_Tomada")]
        public string? AccionTomada { get; set; }
        [StringLength(2000)]
        [Column("NarrativaSituacion")]
        public string? NarrativaSituacion { get; set; }
        public int? ReferidoPor { get; set; }
        [StringLength(25)]
        [Column("RelacionAdulto")]
        public string? RelacionAdulto { get; set; }
        [StringLength(75)]
        [Column("ServicioSolicitado")]
        public string? ServicioSolicitado { get; set; }
        [Column("Servicio_FechaNotificacion")]
        public DateTime? ServicioFechaNotificacion { get; set; }
        [StringLength(25)]
        public string? Antecedentes { get; set; }
        [StringLength(75)]
        public string? Determinacion { get; set; }
        [Column("Determinacion_Fecha")]
        public DateTime? DeterminacionFecha { get; set; }
        [StringLength(500)]
        [Column("Determinacion_Razon")]
        public string? DeterminacionRazon { get; set; }
        [StringLength(75)]
        [Column("AsignacionRegion")]
        public string? AsignacionRegion { get; set; }
        [StringLength(75)]
        [Column("AsignacionOficina")]
        public string? AsignacionOficina { get; set; }
        [StringLength(50)]
        public string? Clasificacion { get; set; }
        [StringLength(75)]
        [Column("OrigenReferido")]
        public string? OrigenReferido { get; set; }
        [StringLength(75)]
        [Column("AsignacionReferido")]
        public string? AsignacionReferido { get; set; }
        public int? AgenciaId { get; set; }
        [StringLength(75)]
        [Column("Agencia_SolicitadoPara")]
        public string? AgenciaSolicitadoPara { get; set; }
        [StringLength(500)]
        [Column("Agencia_Solicitud")]
        public string? AgenciaSolicitud { get; set; }
        [Required]
        [StringLength(40)]
        public required string CreateUser { get; set; }
        [Required]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [StringLength(40)]
        public string? ModifiedUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public required bool Activo { get; set; } = true;

    }
}
