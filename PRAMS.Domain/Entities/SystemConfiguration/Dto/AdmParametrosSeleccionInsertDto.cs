﻿namespace PRAMS.Domain.Entities.SystemConfiguration.Dto
{
    public class AdmParametrosSeleccionInsertDto
    {
        public AdmParametrosSeleccionInsertDto(int categoriaID, string parametro, string? descripcion, string? tX_Filtro1, string? tX_Filtro2, string? tX_Filtro3)
        {
            CategoriaID = categoriaID;
            Parametro = parametro;
            Descripcion = descripcion;
            TX_Filtro1 = tX_Filtro1;
            TX_Filtro2 = tX_Filtro2;
            TX_Filtro3 = tX_Filtro3;
            Activo = true;
            CreateUser = "03334448-73b4-438f-8fdf-784dbab58150";
            CreateDate = DateTime.Now;
        }

        public int CategoriaID { get; set; }
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
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public bool Activo { get; set; } = true;
    }
}
