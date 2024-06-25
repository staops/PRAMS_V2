using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRAMS.Domain.Models.SystemConfiguration
{
    /*
     * [dbo].[Adm_ParametroCategoria] 
     */
    [Table("Adm_ParametroCategoria")]
    public class AdmParametroCategoria
    {
        public AdmParametroCategoria()
        {
            AdmParametrosSeleccions = new HashSet<AdmParametrosSeleccion>();
        }

        [Key]
        public int CategoriaID { get; set; }
        [Required]
        public required string Categoria { get; set; }
        [Required]
        public required string Descripcion { get; set; }
        public string? TX_Filtro1_Nombre { get; set; }
        public string? TX_Filtro2_Nombre { get; set; }
        public string? TX_Filtro3_Nombre { get; set; }
        public string? TX_Filtro4_Nombre { get; set; }
        public string? TX_Filtro5_Nombre { get; set; }
        public string? TX_Filtro6_Nombre { get; set; }
        public string? TX_Filtro7_Nombre { get; set; }
        public string? TX_Filtro8_Nombre { get; set; }
        public string? TX_Filtro9_Nombre { get; set; }
        public string? ModifiedUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
        [Required]
        public required string CreateUser { get; set; }
        [Required]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public required bool Activo { get; set; } = true;

        public virtual ICollection<AdmParametrosSeleccion>? AdmParametrosSeleccions { get; set; }
    }
}
