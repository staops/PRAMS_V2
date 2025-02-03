namespace PRAMS.Domain.Entities.SystemConfiguration.Dto
{
    public class AdmParametroCategoriaInsertDto
    {
        public AdmParametroCategoriaInsertDto(string categoria, string descripcion, string? tX_Filtro1_Nombre, string? tX_Filtro2_Nombre, string? tX_Filtro3_Nombre, string? tX_Filtro4_Nombre, string? tX_Filtro5_Nombre, string? tX_Filtro6_Nombre, string? tX_Filtro7_Nombre, string? tX_Filtro8_Nombre, string? tX_Filtro9_Nombre)
        {
            Categoria = categoria;
            Descripcion = descripcion;
            TX_Filtro1_Nombre = tX_Filtro1_Nombre;
            TX_Filtro2_Nombre = tX_Filtro2_Nombre;
            TX_Filtro3_Nombre = tX_Filtro3_Nombre;
            TX_Filtro4_Nombre = tX_Filtro4_Nombre;
            TX_Filtro5_Nombre = tX_Filtro5_Nombre;
            TX_Filtro6_Nombre = tX_Filtro6_Nombre;
            TX_Filtro7_Nombre = tX_Filtro7_Nombre;
            TX_Filtro8_Nombre = tX_Filtro8_Nombre;
            TX_Filtro9_Nombre = tX_Filtro9_Nombre;
        }

        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public string? TX_Filtro1_Nombre { get; set; }
        public string? TX_Filtro2_Nombre { get; set; }
        public string? TX_Filtro3_Nombre { get; set; }
        public string? TX_Filtro4_Nombre { get; set; }
        public string? TX_Filtro5_Nombre { get; set; }
        public string? TX_Filtro6_Nombre { get; set; }
        public string? TX_Filtro7_Nombre { get; set; }
        public string? TX_Filtro8_Nombre { get; set; }
        public string? TX_Filtro9_Nombre { get; set; }

    }
}
