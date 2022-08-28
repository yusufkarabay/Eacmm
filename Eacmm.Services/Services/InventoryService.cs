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
    public class InventoryService:IInventoryService
    {
        private readonly IMapper _mapper;   
        private readonly IUnitofWork _unitofwork;   
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryService(IMapper mapper, IUnitofWork unitofwork, IInventoryRepository inventoryRepository)
        {
            _mapper=mapper;
            _unitofwork=unitofwork;
            _inventoryRepository=inventoryRepository;
        }
    }
}
