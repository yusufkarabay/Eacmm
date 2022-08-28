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
    public class EntranceCardService:IEntranceCardService
    {
        private readonly IMapper _mapper; 
        private readonly IUnitofWork _unitofWork;
        private readonly IEntranceCardRepository _entranceCardRepository;

        public EntranceCardService(IUnitofWork unitofWork, IEntranceCardRepository entranceCardRepository, IMapper mapper)
        {
            _unitofWork=unitofWork;
            _entranceCardRepository=entranceCardRepository;
            _mapper=mapper;
        }
    }
}
