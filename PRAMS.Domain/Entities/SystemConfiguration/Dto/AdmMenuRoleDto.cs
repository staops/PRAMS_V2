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

        private IList<AdmMenuRoleDosDto> subMenu = new List<AdmMenuRoleDosDto>();

        public IList<AdmMenuRoleDosDto>? SubMenu { get { return GetSubMenu() ?? subMenu; } set { SetSubMenu(value); } }

        public IList<AdmMenuRoleDosDto> GetSubMenu()
        {
            return subMenu.Where(x => x.MenuElementParentId == MenuElementId).ToList();
        }

        public void SetSubMenu(IList<AdmMenuRoleDosDto> value)
        {
            subMenu = value;
        }
    }

    public class AdmMenuRoleDosDto
    {
        public required string Nombre { get; set; }
        public required string Controlador { get; set; }
        public required string Accion { get; set; }
        public required string Icono { get; set; }
        public int? MenuElementParentId { get; set; }
    }
}
