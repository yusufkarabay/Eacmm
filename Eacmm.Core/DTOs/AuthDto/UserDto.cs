using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Core.DTOs.AuthDto
{
    public class UserDto
    {
        public string Id { get; set; }
        //  public string UserName { get; set; }
        public string Email { get; set; }
        public string CityPlateCode { get; set; }
    }
}
