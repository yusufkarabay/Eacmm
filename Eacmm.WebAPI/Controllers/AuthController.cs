using Eacmm.Core.DTOs.AuthDto;
using Eacmm.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eacmm.WebAPI.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : CustomBaseController
    {
        private readonly IEacmmAuthenticationService _eacmmAuthenticationService;

        public AuthController(IEacmmAuthenticationService eacmmAuthenticationService)
        {
            _eacmmAuthenticationService=eacmmAuthenticationService;
        }



        /// <summary>
        /// Create Token
        /// </summary>
        /// <param name="loginDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateToken([FromBody] LoginDto loginDto)
        {
            var result = await _eacmmAuthenticationService.CreateTokenAsync(loginDto);

            return ActionResultInstance(result);

        }



        [HttpPost]
        public async Task<IActionResult> CreateTokenByClient([FromBody] ClientLoginDto clientLoginDto)
        {
            var result = _eacmmAuthenticationService.CreateTokenByClient(clientLoginDto);

            return ActionResultInstance(result);
        }


        [HttpPost]
        public async Task<IActionResult> RevokeRefreshToken([FromBody] RefreshTokenDto refreshTokenDto)
        {
            var result = await _eacmmAuthenticationService.RevokeRefreshTokenAsync(refreshTokenDto.RefreshTokenCode);

            return ActionResultInstance(result);

        }

        [HttpPost]
        public async Task<IActionResult> CreateTokenByRefreshToken([FromBody] RefreshTokenDto refreshTokenDto)
        {
            var result = await _eacmmAuthenticationService.CreateTokenByRefreshTokenAsync(refreshTokenDto.RefreshTokenCode);

            return ActionResultInstance(result);

        }


    }
}
