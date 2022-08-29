using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Core.Entities.Concrete
{
    public interface IBaseEntity
    {
       
        Guid Id { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime? LastModifiedAt { get; set; }
        string CreatedBy { get; set; }
        string LastModifiedBy { get; set; }
        bool IsEnabled { get; set; }
        bool IsDeleted { get; set; }
        long Version { get; set; }
    }
}
