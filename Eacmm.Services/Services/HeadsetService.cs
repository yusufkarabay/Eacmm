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
    public class HeadsetService:IHeadSetService
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IHeadsetRepository _headsetRepository;

        public HeadsetService(IMapper mapper, IUnitofWork unitofWork, IHeadsetRepository headsetRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _headsetRepository=headsetRepository;
        }
    }
}
