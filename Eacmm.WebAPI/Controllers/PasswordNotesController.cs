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
    public class PasswordNotesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;
        private readonly IPasswordNoteService _passwordNoteService; 
        private readonly IPasswordNoteRepository _passwordNoteRepository;

        public PasswordNotesController(IMapper mapper, IUnitofWork unitofWork, IPasswordNoteService passwordNoteService, IPasswordNoteRepository passwordNoteRepository)
        {
            _mapper=mapper;
            _unitofWork=unitofWork;
            _passwordNoteService=passwordNoteService;
            _passwordNoteRepository=passwordNoteRepository;
        }
    }
}
