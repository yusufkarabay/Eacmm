using Eacmm.Core.Configuration;
using Eacmm.Core.DTOs.AuthDto;
using Eacmm.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(User user);
        ClientTokenDto CreateTokenByClient(Client client);
    }
}
