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
    public class DepartmentService:IDepartmentService
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IUnitofWork unitofWork, IDepartmentRepository departmentRepository, IMapper mapper)
        {

            _unitofWork=unitofWork;
            _departmentRepository=departmentRepository;
            _mapper=mapper;
        }
    }
}
