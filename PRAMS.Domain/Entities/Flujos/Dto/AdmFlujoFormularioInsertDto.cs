namespace PRAMS.Domain.Entities.Flujos.Dto
{
    public class AdmFlujoFormularioInsertDto
    {
        public required string TipoCaso { get; set; }
        public required string Formulario { get; set; }
        public required int TablaBase { get; set; }
        public required string Descripcion { get; set; }
        public required int OrdenFormulario { get; set; }
        public required string NivelCaso { get; set; }
        public string? TXFiltro { get; set; }
        public string? TXFiltro2 { get; set; }
        public string? TXFiltro3 { get; set; }
    }
}
