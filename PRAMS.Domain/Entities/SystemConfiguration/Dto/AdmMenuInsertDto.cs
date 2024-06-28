namespace PRAMS.Domain.Entities.SystemConfiguration.Dto
{
    public class AdmMenuInsertDto
    {
        public required string Nombre { get; set; }
        public required string Controlador { get; set; }
        public required string Accion { get; set; }
        public required string Icono { get; set; }
        public int? MenuElementParentId { get; set; }
        public int Orden { get; set; }
    }
}
