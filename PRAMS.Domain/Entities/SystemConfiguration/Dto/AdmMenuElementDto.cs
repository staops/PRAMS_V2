namespace PRAMS.Domain.Entities.SystemConfiguration.Dto
{
    public class AdmMenuElementDto
    {
        public int MenuElementId { get; set; }
        public required string Nombre { get; set; }
        public required string Controlador { get; set; }
        public required string Accion { get; set; }
        public required string Icono { get; set; }
        public IList<AdmSubMenuElementDto>? SubMenu { get; set; }
    }

    public class AdmSubMenuElementDto
    {
        public int MenuElementId { get; set; }
        public required string Nombre { get; set; }
        public required string Controlador { get; set; }
        public required string Accion { get; set; }
        public required string Icono { get; set; }
        public int? MenuElementParentId { get; set; }
        public IList<AdmSubSubMenuElementDto>? SubSubMenu { get; set; }
    }

    public class AdmSubSubMenuElementDto
    {
        public int MenuElementId { get; set; }
        public required string Nombre { get; set; }
        public required string Controlador { get; set; }
        public required string Accion { get; set; }
        public required string Icono { get; set; }
        public int? MenuElementParentId { get; set; }
    }
}
