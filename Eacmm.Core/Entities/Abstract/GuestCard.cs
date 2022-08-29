using Eacmm.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Eacmm.Core.Entities.Abstract
{
    public class GuestCard : BaseEntity, IGiveAndTake
    {
        public string SpecialNo { get ; set ; }
        public string DeliveryEmployee { get ; set ; }
        public string ReceiverEmployee { get ; set ; }
        public Guid EmployeeId { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public Employee Employee { set; get; }
    }
}
