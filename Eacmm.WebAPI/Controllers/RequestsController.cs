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
    public class RequestsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IRequestRepository _requestRepository;
        private readonly IRequestService _requestService;

        public RequestsController(IMapper mapper, IUnitofWork unitofWork, IRequestRepository requestRepository, IRequestService requestService)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _requestRepository=requestRepository;
            _requestService=requestService;
        }
    }
}
