using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Core.Entities.Abstract
{
    public class Contract:BaseEntity
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Company { get; set; }
        public string? CompanyAdress { get; set; }
        public string? CompanyTel { get; set; }
        public string? Notes { get; set; }
        public string CreatedEmployee { get; set; }      

    }
}
