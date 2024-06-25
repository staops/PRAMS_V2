using System.ComponentModel.DataAnnotations;

namespace PRAMS.Domain.Entities.SystemConfiguration.Dto
{
    public class AdmParametrosNivel3Dto
    {
        public int CategoriaID { get; set; }
        public required string Category { get; set; }
        public string? TX_Filter { get; set; }
        public string? CatDescription { get; set; }
        public string? TX_FilterTwo { get; set; }
    }
}
