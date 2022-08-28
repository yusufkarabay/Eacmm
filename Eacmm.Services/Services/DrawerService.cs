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
    public class DrawerService:IDrawerService
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IDrawerRepository _drawerRepository;

        public DrawerService(IUnitofWork unitofWork, IDrawerRepository drawerRepository, IMapper mapper)
        {

            _unitofWork=unitofWork;
            _drawerRepository=drawerRepository;
            _mapper=mapper;
        }
    }
}
