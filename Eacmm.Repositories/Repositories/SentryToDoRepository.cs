using Eacmm.Core.Entities.Abstract;
using Eacmm.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Repositories.Repositories
{
    public class SentryToDoRepository : GenericRepository<SentryToDo>, ISentryToDoRepository
    {
        public SentryToDoRepository(EacmmDbContext dbContext) : base(dbContext)
        {
        }
    }
}
