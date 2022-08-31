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
    public class GuestCard : BaseEntity, IGiveAndTake, ISpecialNo   
    {
        public string SpecialNo { get ; set ; }
        public Guid? DeliveryEmployeeId { get; set; }
        public Guid? ReceiverEmployeeId { get; set; }

    }
}
