using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Eacmm.Core.Entities.Abstract
{
    public class SentryToDo:BaseEntity
    {
        public string ToDo { get; set; }
        public Guid DepartmentId { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public Department Department { set; get; }
    }
}
