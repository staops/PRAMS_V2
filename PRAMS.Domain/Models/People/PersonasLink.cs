using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.People
{
    [Table("Conf_Personas_Links")]
    public class PersonasLink
    {
        [Key]
        public int LinkId { get; set; }
        [Required]
        public required int PersonaId { get; set; }
        [Required]
        [StringLength(25)]
        public required string RMO { get; set; }
        [Required]
        [StringLength(75)]
        public required string TipoLink { get; set; }
        [StringLength(75)]
        public string? Relacion { get; set; }
        public bool ViveEnElHogar { get; set; } = false;
        public bool JefeDeFamilia { get; set; } = false;
        public string? EstadoEmpleo { get; set; }
        public bool Pensionado { get; set; } = false;
        public int? ReferidoId { get; set; }
        [Required]
        public required bool CasoActivo { get; set; } = true;



        [ForeignKey("PersonaId")]
        public virtual Persona? Persona { get; set; }
    }
}
