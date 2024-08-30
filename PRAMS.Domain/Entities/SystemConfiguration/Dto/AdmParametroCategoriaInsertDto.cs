namespace PRAMS.Domain.Entities.SystemConfiguration.Dto
{
    public class AdmParametroCategoriaInsertDto
    {
        public required string Categoria { get; set; }
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
        public required string CreateUser { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public required bool Activo { get; set; } = true;
    }
}
