﻿using PRAMS.Domain.Models.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.Flujos
{
    [Table("Adm_FlujoFormularioEtapas")]
    public class AdmFlujoFormularioEtapa
    {
        public AdmFlujoFormularioEtapa()
        {
            AdmFlujoFormularioEtapaAcciones = new HashSet<AdmFlujoFormularioEtapaAccion>();
        }

        [Key]
        public required int FormularioEtapaId { get; set; }
        [Required]
        public required int FormularioId { get; set; }
        [Required]
        [StringLength(100)]
        public required string NombreEtapa { get; set; }
        [Required]
        public required int OrdenEtapa { get; set; }
        [Required]
        [StringLength(75)]
        public required string TipoEtapa { get; set; }
        [StringLength(75)]
        public string? ColorEtapa { get; set; }
        [Required]
        public bool Completado { get; set; }
        [Required]
        public bool Concurrencia { get; set; }
        [Required]
        public int ConcurrenciaEtapa { get; set; }
        public int? NotaSatarId { get; set; }
        public int? NotaEndId { get; set; }
        [Required]
        [StringLength(30)]
        public required string CreateUser { get; set; }
        [Required]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [StringLength(30)]
        public string? ModifiedUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public required bool Activo { get; set; } = true;



        [ForeignKey("FormularioId")]
        public virtual AdmFlujoFormulario? AdmFlujoFormulario { get; set; }

        public virtual ICollection<AdmFlujoFormularioEtapaAccion> AdmFlujoFormularioEtapaAcciones { get; set; }

        public virtual ICollection<FormFormularioFirma>? FormFormularioFirmas { get; set; }
    }
}
