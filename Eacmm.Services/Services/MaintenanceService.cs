using AutoMapper;
using Eacmm.Core;
using Eacmm.Core.Repositories;
using Eacmm.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Services.Services
{
    public class MaintenanceService:IMaintenanceService
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IMaintenanceRepository _maintenanceRepository;

        public MaintenanceService(IMapper mapper, IUnitofWork unitofWork, IMaintenanceRepository maintenanceRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _maintenanceRepository=maintenanceRepository;
        }
    }
}
