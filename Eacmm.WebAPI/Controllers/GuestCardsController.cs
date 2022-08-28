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
    public class GuestCardsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IGuestCardService _guestCardService;
        private readonly IGuestCardRepository _guestCardRepository;

        public GuestCardsController(IMapper mapper, IUnitofWork unitofWork, IGuestCardService guestCardService, IGuestCardRepository guestCardRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _guestCardService=guestCardService;
            _guestCardRepository=guestCardRepository;
        }
    }
}
