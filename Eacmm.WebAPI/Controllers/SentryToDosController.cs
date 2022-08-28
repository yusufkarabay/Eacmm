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
    public class SentryToDosController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly ISentryToDoService sentryToDoService;
        private readonly ISentryToDoRepository sentryToDoRepository;

        public SentryToDosController(IMapper mapper, IUnitofWork unitofWork, ISentryToDoService sentryToDoService, ISentryToDoRepository sentryToDoRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            this.sentryToDoService=sentryToDoService;
            this.sentryToDoRepository=sentryToDoRepository;
        }
    }
}
