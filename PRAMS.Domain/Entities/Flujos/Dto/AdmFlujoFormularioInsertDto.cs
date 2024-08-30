namespace PRAMS.Domain.Entities.Flujos.Dto
{
    public class AdmFlujoFormularioInsertDto
    {
        public AdmFlujoFormularioInsertDto(string tipoCaso, string formulario, string tablaBase, int ordenFormulario, string nivelCaso, string? descripcion, string? tXFiltro1, string? tXFiltro2, string? tXFiltro3)
        {
            TipoCaso = tipoCaso;
            Formulario = formulario;
            TablaBase = tablaBase;
            Descripcion = descripcion;
            OrdenFormulario = ordenFormulario;
            NivelCaso = nivelCaso;
            TXFiltro1 = tXFiltro1;
            TXFiltro2 = tXFiltro2;
            TXFiltro3 = tXFiltro3;
        }

        public string TipoCaso { get; set; }
        public string Formulario { get; set; }
        public string TablaBase { get; set; }
        public string? Descripcion { get; set; }
        public int OrdenFormulario { get; set; }
        public string NivelCaso { get; set; }
        public string? TXFiltro1 { get; set; }
        public string? TXFiltro2 { get; set; }
        public string? TXFiltro3 { get; set; }
    }
}
