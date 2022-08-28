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
    public class HeadsetsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IHeadSetService _headSetService;   
        private readonly IHeadsetRepository _headsetRepository;

        public HeadsetsController(IMapper mapper, IUnitofWork unitofWork, IHeadSetService headSetService, IHeadsetRepository headsetRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _headSetService=headSetService;
            _headsetRepository=headsetRepository;
        }
    }
}
