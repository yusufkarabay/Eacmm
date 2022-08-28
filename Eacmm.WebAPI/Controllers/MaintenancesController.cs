using AutoMapper;
using Eacmm.Core;
using Eacmm.Core.Repositories;
using Eacmm.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eacmm.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenancesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IMaintenanceService _maintenanceService;
        private readonly IMaintenanceRepository _maintenanceRepository;

        public MaintenancesController(IMapper mapper, IUnitofWork unitofWork, IMaintenanceService maintenanceService, IMaintenanceRepository maintenanceRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _maintenanceService=maintenanceService;
            _maintenanceRepository=maintenanceRepository;
        }
    }
}
