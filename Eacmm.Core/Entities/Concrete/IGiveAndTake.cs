﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Core.Entities.Concrete
{
    public interface IGiveAndTake
    {
        Guid? DeliveryEmployeeId { get; set; }
        Guid? ReceiverEmployeeId { get; set; }

    }
}
