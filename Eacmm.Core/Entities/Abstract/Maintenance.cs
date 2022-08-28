using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Core.Entities.Abstract
{
    public class Maintenance:BaseEntity
    {
        public int AgainMonth { get; set; }
        public DateTime FirstTime { get; set; }
        public string CreatedEmployee { get; set; }
    }
}
