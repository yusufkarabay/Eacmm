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
    public class CabinetService:ICabinetService
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly ICabinetRepository _cabinetRepository;

        public CabinetService(IMapper mapper, IUnitofWork unitofWork, ICabinetRepository cabinetRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _cabinetRepository=cabinetRepository;
        }
    }
}
