﻿using AutoMapper;
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
    public class GuestCarService:IGuestCardService
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IGuestCardRepository _guestCardRepository;

        public GuestCarService(IMapper mapper, IUnitofWork unitofWork, IGuestCardRepository guestCardRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _guestCardRepository=guestCardRepository;
        }
    }
}
