using AutoMapper;
using Eacmm.Core;
using Eacmm.Core.DTOs.CabinetDto;
using Eacmm.Core.Entities.Abstract;
using Eacmm.Core.Repositories;
using Eacmm.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eacmm.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CabinetsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly ICabinetService _cabinetService;
        private readonly ICabinetRepository _cabinetRepository;

        public CabinetsController(IMapper mapper, IUnitofWork unitofWork, ICabinetService cabinetService, ICabinetRepository cabinetRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _cabinetService=cabinetService;
            _cabinetRepository=cabinetRepository;
        }

        /// <summary>
        /// Create Cabinet
        /// </summary>
        /// <param name="createCabinetDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateBranch([FromBody] CreateCabinetDto createCabinetDto)
        {

            await _cabinetService.CreateCabinet(_mapper.Map<Cabinet>(createCabinetDto));
            await _unitofWork.SaveChangesAsync();
            return Created("Added", createCabinetDto);
        }




        [HttpPut("{id}")]
        public async Task<IActionResult> CabinetDeliver(Guid id, [FromBody] DeliverCabinetDto deliverCabinetDto)
        {
            var isCabinetExists = await _cabinetRepository.ExistsAsync(id);
            if (!isCabinetExists)
            {
                return NotFound();
            }

            var mappedCabinet = _mapper.Map<Cabinet>(deliverCabinetDto);
            mappedCabinet.Id = id;

            (bool hasError, Exception? exception) = await _cabinetService.CabinetDeliver(id, mappedCabinet);
            if (hasError)
            {
                return Problem(exception.Message);
            }

            return Ok();
        }

    }
}
