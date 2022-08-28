using AutoMapper;
using Eacmm.Core;
using Eacmm.Core.Repositories;
using Eacmm.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eacmm.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoriesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IInventoryService _inventoryService;
        private readonly IInventoryRepository _inventoryRepository;

        public InventoriesController(IMapper mapper, IUnitofWork unitofWork, IInventoryService inventoryService, IInventoryRepository inventoryRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _inventoryService=inventoryService;
            _inventoryRepository=inventoryRepository;
        }
    }
}
