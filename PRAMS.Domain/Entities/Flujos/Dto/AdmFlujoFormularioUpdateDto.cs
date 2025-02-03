﻿namespace PRAMS.Domain.Entities.Flujos.Dto
{
    public class AdmFlujoFormularioUpdateDto
    {
        public int FormularioId { get; set; }
        public required string TipoCaso { get; set; }
        public required string Formulario { get; set; }
        public required string TablaBase { get; set; }
        public string? Descripcion { get; set; }
        public required int OrdenFormulario { get; set; }
        public required string NivelCaso { get; set; }
        public string? TXFiltro1 { get; set; }
        public string? TXFiltro2 { get; set; }
        public string? TXFiltro3 { get; set; }
    }
}
