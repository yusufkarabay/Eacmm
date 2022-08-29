using Eacmm.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Core.Entities.Abstract
{
    public class BaseEntity:IBaseEntity
    {

        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? LastModifiedAt { get; set; }
        public bool IsEnabled { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        public string CreatedBy { get; set; } = "Yusuf";
        public string LastModifiedBy { get; set; } = "Hasan";

        [ConcurrencyCheck]
        public long Version { get; set; } = 0;
    }
}
