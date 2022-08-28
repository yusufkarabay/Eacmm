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
    public class SentryDonesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly ISentryDoneService _sentryDoneService;
        private readonly ISentryDoneRepository  _sentryDoneRepository;

        public SentryDonesController(IMapper mapper, IUnitofWork unitofWork, ISentryDoneService sentryDoneService, ISentryDoneRepository sentryDoneRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _sentryDoneService=sentryDoneService;
            _sentryDoneRepository=sentryDoneRepository;
        }
    }
}
