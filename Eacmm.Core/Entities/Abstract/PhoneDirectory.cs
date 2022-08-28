using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Core.Entities.Abstract
{
    public class PhoneDirectory:BaseEntity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string? Info { get; set; }
        public string CreatedEmployee { get; set; }
    }
}
