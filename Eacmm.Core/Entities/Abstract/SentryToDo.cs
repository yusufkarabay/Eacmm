using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Core.Entities.Abstract
{
    public class SentryToDo:BaseEntity
    {
        public string ToDo { get; set; }
        public string CreatedEmployee { get; set; }
    }
}
