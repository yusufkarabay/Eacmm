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
    public class GeneratorUsedTimesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IGeneratorUsedTimeService _generatorUsedTimeService;
        private readonly IGeneratorUsedTimeRepository _generatorUsedTimeRepository;

        public GeneratorUsedTimesController(IMapper mapper, IUnitofWork unitofWork, IGeneratorUsedTimeService generatorUsedTimeService, IGeneratorUsedTimeRepository generatorUsedTimeRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _generatorUsedTimeService=generatorUsedTimeService;
            _generatorUsedTimeRepository=generatorUsedTimeRepository;
        }
    }
}
