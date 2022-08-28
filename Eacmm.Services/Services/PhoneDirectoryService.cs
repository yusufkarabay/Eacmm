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
    public class PhoneDirectoryService:IPhoneDirectoryService
    {
        private readonly IMapper _mapper;  
        private readonly IUnitofWork _unitofWork;
        private readonly IPhoneDirectoryRepository _phoneDirectoryRepository;

        public PhoneDirectoryService(IPhoneDirectoryService phoneDirectoryService, IUnitofWork unitofWork, IPhoneDirectoryRepository phoneDirectoryRepository, IMapper mapper)
        {

            _unitofWork=unitofWork;
            _phoneDirectoryRepository=phoneDirectoryRepository;
            _mapper=mapper;
        }
    }
}
