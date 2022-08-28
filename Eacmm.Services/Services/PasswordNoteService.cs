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
    public class PasswordNoteService:IPasswordNoteService
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IPasswordNoteRepository _passwordNoteRepository;

        public PasswordNoteService(IMapper mapper, IUnitofWork unitofWork, IPasswordNoteRepository passwordNoteRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _passwordNoteRepository=passwordNoteRepository;
        }
    }
}
