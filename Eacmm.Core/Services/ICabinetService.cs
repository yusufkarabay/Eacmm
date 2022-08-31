using Eacmm.Core.Entities.Abstract;
using Eacmm.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Core.Services
{
    public interface ICabinetService
    {
        Task<Cabinet> CreateCabinet(Cabinet cabinet);
        Task<(bool, Exception?)> CabinetDeliver(Guid cabinetId, Cabinet cabinet);
      
    }
}
