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
    public class SentryDoneService:ISentryDoneService
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly ISentryDoneRepository _sentryDoneRepository;

        public SentryDoneService(IMapper mapper, IUnitofWork unitofWork, ISentryDoneRepository sentryDoneRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _sentryDoneRepository=sentryDoneRepository;
        }
    }
}
