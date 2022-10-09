using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Core.DTOs.AuthDto
{
    public class ClientLoginDto
    {
        // Client Tipini kontrol edecek
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
