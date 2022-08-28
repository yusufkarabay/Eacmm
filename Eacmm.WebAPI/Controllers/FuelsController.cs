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
    public class FuelsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IFuelService _fuelService;
        private readonly IFuelRepository _fuelRepository;

        public FuelsController(IMapper mapper, IUnitofWork unitofWork, IFuelService fuelService, IFuelRepository fuelRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _fuelService=fuelService;
            _fuelRepository=fuelRepository;
        }
    }
}
