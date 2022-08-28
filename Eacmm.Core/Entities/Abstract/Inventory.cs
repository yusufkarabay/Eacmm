using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Core.Entities.Abstract
{
    public class Inventory:BaseEntity
    {
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string? Info { get; set; }
        public string CreatedEmployee { get; set; }
    }
}
