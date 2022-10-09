using Eacmm.Core.DTOs.AuthDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Core.Services
{

    //identty kütüphanesini kullandığımız için ıuser repository yapmadık her metot zaten orda var
    //gerekli işlemleri çağırıp service tarafında işleyeceğiz.
    public interface IUserService
    {

        Task<CustomResponseDto<UserDto>> CreateUserAsync(CreateUserDto createUserDto);

        Task<CustomResponseDto<UserDto>> GetUserByUserNameAsync(string userName);

    }
}
