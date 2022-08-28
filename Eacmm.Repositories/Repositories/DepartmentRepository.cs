using Eacmm.Core.Entities.Abstract;
using Eacmm.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Repositories.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(EacmmDbContext dbContext) : base(dbContext)
        {
        }
    }
}
