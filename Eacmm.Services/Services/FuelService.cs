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
    public class FuelService:IFuelService
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;    
        private readonly IFuelRepository _fuelRepository;

        public FuelService(IMapper mapper, IUnitofWork unitofWork, IFuelRepository fuelRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _fuelRepository=fuelRepository;
        }
    }
}
