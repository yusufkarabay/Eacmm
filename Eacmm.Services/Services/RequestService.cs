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
    public class RequestService : IRequestService
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IRequestRepository _requestRepository;

        public RequestService(IMapper mapper, IUnitofWork unitofWork, IRequestRepository requestRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _requestRepository=requestRepository;
        }
    }
}
