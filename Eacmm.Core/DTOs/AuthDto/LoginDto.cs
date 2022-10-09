using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Core.DTOs.AuthDto
{
    public class LoginDto
    {
        //kullancıların girişini kontrol edecek. Veritabanında olup olmadığını
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
