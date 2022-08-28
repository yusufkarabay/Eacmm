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
    public class EmployeesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IMapper mapper, IUnitofWork unitofWork, IEmployeeRepository employeeRepository, IEmployeeService employeeService)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _employeeRepository=employeeRepository;
            _employeeService=employeeService;
        }
    }
}
