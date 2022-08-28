using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Core.Entities.Abstract
{
    public class PasswordNote:BaseEntity
    {
        public string Title { get; set; }
        public string Password { get; set; }
        public string? ThisPasswordNote { get; set; }
        public string CreatedEmployee { get; set; }
    }
}
