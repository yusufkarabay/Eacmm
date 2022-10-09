using Eacmm.Core.DTOs.AuthDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eacmm.WebAPI.Controllers
{
    public class CustomBaseController : ControllerBase
    {
        public IActionResult ActionResultInstance<T>(CustomResponseDto<T> customResponseDto) where T : class
        {
            return new ObjectResult(customResponseDto)
            {
                StatusCode=customResponseDto.StatusCode
            };
        }
    }
}
