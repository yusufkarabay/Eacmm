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
    public class DepartmentsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IDepartmentService _departmentService;

        public DepartmentsController(IMapper mapper, IUnitofWork unitofWork, IDepartmentRepository departmentRepository, IDepartmentService departmentService)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _departmentRepository=departmentRepository;
            _departmentService=departmentService;
        }
    }
}
