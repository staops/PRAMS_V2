using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAMS.Domain.Entities.People.Dto
{
    public class PersonSearchDto
    {
        public string? SeguroSocial { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? Nombre { get; set; }
        public string? TelefonoResidencia { get; set; }
        public string? TelefonoCelular { get; set; }
        public string? TelefonoFamiliar { get; set; }
        public string? Email { get; set; }
    }
}
