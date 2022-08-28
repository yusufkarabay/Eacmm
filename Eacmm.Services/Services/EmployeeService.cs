using AutoMapper;
using Eacmm.Core;
using Eacmm.Core.Repositories;
using Eacmm.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Services.Services
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IMapper _mapper;   
        private readonly IUnitofWork _unitofWork;
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IUnitofWork unitofWork, IEmployeeRepository employeeRepository, IMapper mapper)
        {

            _unitofWork=unitofWork;
            _employeeRepository=employeeRepository;
            _mapper=mapper;
        }
    }
}
