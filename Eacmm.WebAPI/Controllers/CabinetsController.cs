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
    public class CabinetsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly ICabinetService _cabinetService;
        private readonly ICabinetRepository _cabinetRepository;

        public CabinetsController(IMapper mapper, IUnitofWork unitofWork, ICabinetService cabinetService, ICabinetRepository cabinetRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _cabinetService=cabinetService;
            _cabinetRepository=cabinetRepository;
        }
    }
}
