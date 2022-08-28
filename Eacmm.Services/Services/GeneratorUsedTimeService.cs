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
    public class GeneratorUsedTimeService:IGeneratorUsedTimeService
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IGeneratorUsedTimeRepository _generatorUsedTimeRepository;

        public GeneratorUsedTimeService(IMapper mapper, IUnitofWork unitofWork, IGeneratorUsedTimeRepository generatorUsedTimeRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _generatorUsedTimeRepository=generatorUsedTimeRepository;
        }
    }
}
