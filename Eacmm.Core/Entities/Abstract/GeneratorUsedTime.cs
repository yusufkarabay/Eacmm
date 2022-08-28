using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Core.Entities.Abstract
{
    public class GeneratorUsedTime:BaseEntity
    {
        public int GeneratorWorkedTime { get; set; }
        public string AddedEmployee { get; set; }
    }
}
