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
    public class EntranceCardsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IEntranceCardService _entranceCardService; 
        private readonly IEntranceCardRepository _entranceCardRepository;

        public EntranceCardsController(IMapper mapper, IUnitofWork unitofWork, IEntranceCardService entranceCardService, IEntranceCardRepository entranceCardRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _entranceCardService=entranceCardService;
            _entranceCardRepository=entranceCardRepository;
        }
    }
}
