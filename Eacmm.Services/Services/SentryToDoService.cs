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
    public class SentryToDoService:ISentryToDoService
    {

        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly ISentryToDoRepository _sentryToDoRepository;

        public SentryToDoService(IMapper mapper, IUnitofWork unitofWork, ISentryToDoRepository sentryToDoRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _sentryToDoRepository=sentryToDoRepository;
        }
    }
}
