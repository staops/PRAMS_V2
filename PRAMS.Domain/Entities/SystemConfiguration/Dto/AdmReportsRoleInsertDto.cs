using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAMS.Domain.Entities.SystemConfiguration.Dto
{
    public class AdmReportsRoleInsertDto
    {
        public int ReportId { get; set; }
        public required string RoleId { get; set; }
    }
}
