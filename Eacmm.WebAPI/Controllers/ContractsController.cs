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
    public class ContractsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IContractRepository _contractRepository;
        private readonly IContractService _contractService;

        public ContractsController(IMapper mapper, IUnitofWork unitofWork, IContractRepository contractRepository, IContractService contractService)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _contractRepository=contractRepository;
            _contractService=contractService;
        }
    }
}
