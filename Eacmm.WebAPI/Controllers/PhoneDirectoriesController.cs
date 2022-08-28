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
    public class PhoneDirectoriesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IPhoneDirectoryRepository _phoneDirectoryRepository;
        private readonly IPhoneDirectoryService _phoneDirectoryService;

        public PhoneDirectoriesController(IMapper mapper, IUnitofWork unitofWork, IPhoneDirectoryRepository phoneDirectoryRepository, IPhoneDirectoryService phoneDirectoryService)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _phoneDirectoryRepository=phoneDirectoryRepository;
            _phoneDirectoryService=phoneDirectoryService;
        }
    }
}
