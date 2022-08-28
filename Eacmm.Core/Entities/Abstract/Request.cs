using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Core.Entities.Abstract
{
    public class Request:BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsSend { get; set; } = false;
        public bool IsEnd { get; set; } = false;
        public string RequestingEmployee { get; set; }
        public string RequestedEmployee { get; set; }
        public string? RequestEndText { get; set; }
    }
}
