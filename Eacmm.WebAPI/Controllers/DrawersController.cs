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
    public class DrawersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IDrawerRepository _drawerRepository;    
        private readonly IDrawerService _drawerService;

        public DrawersController(IMapper mapper, IUnitofWork unitofWork, IDrawerRepository drawerRepository, IDrawerService drawerService)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _drawerRepository=drawerRepository;
            _drawerService=drawerService;
        }
    }
}
