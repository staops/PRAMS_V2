using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAMS.Domain.Entities.SystemConfiguration.Dto
{
    public class AdmMenuRoleDto
    {
        public int MenuElementId { get; set; }
        public required string Nombre { get; set; }
        public required string Controlador { get; set; }
        public required string Accion { get; set; }
        public required string Icono { get; set; }

        public IList<AdmSubMenuRoleDto>? SubMenu { get; set; }

    }

    public class AdmSubMenuRoleDto
    {
        public int MenuElementId { get; set; }
        public required string Nombre { get; set; }
        public required string Controlador { get; set; }
        public required string Accion { get; set; }
        public required string Icono { get; set; }
        public int? MenuElementParentId { get; set; }
        public IList<AdmSubSubMenuRoleDto>? SubSubMenu { get; set; }
    }

    public class AdmSubSubMenuRoleDto
    {
        public int MenuElementId { get; set; }
        public required string Nombre { get; set; }
        public required string Controlador { get; set; }
        public required string Accion { get; set; }
        public required string Icono { get; set; }
        public int? MenuElementParentId { get; set; }
    }
}
