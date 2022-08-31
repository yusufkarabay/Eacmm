using AutoMapper;
using Eacmm.Core;
using Eacmm.Core.DTOs.CabinetDto;
using Eacmm.Core.Entities.Abstract;
using Eacmm.Core.Repositories;
using Eacmm.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Services.Services
{
    public class CabinetService : ICabinetService
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly ICabinetRepository _cabinetRepository;
        private readonly ICabinetService _cabinetService;

        public CabinetService(IMapper mapper, IUnitofWork unitofWork, ICabinetRepository cabinetRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _cabinetRepository=cabinetRepository;
        }

        public async Task<Cabinet> CreateCabinet(Cabinet cabinet)
        {

            await _cabinetRepository.AddAsync(cabinet);
            await _unitofWork.SaveChangesAsync();
            return cabinet;
        }



        public async Task<(bool, Exception?)> CabinetDeliver(Guid cabinetId, Cabinet cabinet)
        {
            try
            {
                Cabinet getCabinet = await _cabinetRepository.GetByIdAsync(cabinetId);
                cabinet.SpecialNo= getCabinet.SpecialNo;
                await _cabinetRepository.UpdateAsync(cabinet);
                await _unitofWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return (true, ex);
            }

            return (false, null);
        }


    }
}
