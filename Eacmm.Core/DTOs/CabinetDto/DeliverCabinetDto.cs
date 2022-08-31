using Eacmm.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Core.DTOs.CabinetDto
{
    public class DeliverCabinetDto : IGiveAndTake
    {
      
        public Guid? DeliveryEmployeeId { get; set; }
        public Guid? ReceiverEmployeeId { get; set; }
    }
}
