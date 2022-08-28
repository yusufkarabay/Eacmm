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
    public class ContractService:IContractService
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IContractRepository _contractRepository;

        public ContractService(IUnitofWork unitofWork, IContractRepository contractRepository, IMapper mapper)
        {

            _unitofWork=unitofWork;
            _contractRepository=contractRepository;
            _mapper=mapper;
        }
    }
}
