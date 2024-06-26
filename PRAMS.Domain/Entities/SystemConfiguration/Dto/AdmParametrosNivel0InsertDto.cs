using System.ComponentModel.DataAnnotations;

namespace PRAMS.Domain.Entities.SystemConfiguration.Dto
{
    public class AdmParametrosNivel0InsertDto
    {
        public int CategoriaID { get; set; }
        public required string Paremeter { get; set; }
        public string? TX_Filter { get; set; }
        public string? ParamDescription { get; set; }
        public string? TX_FilterTwo { get; set; }
        public string? TX_FilterThree { get; set; }
        public string? TX_FilterFour { get; set; }
        public string? TX_FilterFive { get; set; }
    }
}
