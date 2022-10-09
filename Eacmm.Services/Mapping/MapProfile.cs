using AutoMapper;
using Eacmm.Core.DTOs.AuthDto;
using Eacmm.Core.DTOs.CabinetDto;
using Eacmm.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Services.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            //**************************************************************************
            CreateMap<Cabinet, CreateCabinetDto>().ReverseMap();   
            CreateMap<Cabinet, DeliverCabinetDto>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
        }
    }
}
