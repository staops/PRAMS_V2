using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.SystemConfiguration
{
    /*
     * [dbo].[Adm_ParametrosSeleccion]
    */
    [Table("Adm_ParametrosSeleccion")]
    public class AdmParametrosSeleccion
    {
        [Key]
        public int ParamterosID { get; set; }
        [Required]
        public int CategoriaID { get; set; }
        [Required]
        public string? Parametro { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaStart { get; set; }
        public DateTime? FechaEnd { get; set; }
        public string? TX_Filtro1 { get; set; }
        public string? TX_Filtro2 { get; set; }
        public string? TX_Filtro3 { get; set; }
        public string? TX_Filtro4 { get; set; }
        public string? TX_Filtro5 { get; set; }
        public string? TX_Filtro6 { get; set; }
        public string? TX_Filtro7 { get; set; }
        public string? TX_Filtro8 { get; set; }
        public string? TX_Filtro9 { get; set; }
        public string? ModifiedUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
        [Required]
        public required string CreateUser { get; set; }
        [Required]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public required bool Activo { get; set; } = true;

        [ForeignKey("CategoriaID")]
        public virtual AdmParametroCategoria? AdmParametroCategoria { get; set; }

    }
}
