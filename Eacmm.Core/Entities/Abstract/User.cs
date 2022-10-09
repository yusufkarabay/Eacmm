using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Core.Entities.Abstract
{
    public class User : IdentityUser
    {
        //identity user içerisinde özellikleri kullanır birde bu özelliği ekledim içerisine
        public string CityPlateCode { get; set; }
    }
}
