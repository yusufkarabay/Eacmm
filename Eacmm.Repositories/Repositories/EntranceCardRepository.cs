using Eacmm.Core.Entities.Abstract;
using Eacmm.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Repositories.Repositories
{
    public class EntranceCardRepository : GenericRepository<EntranceCard>, IEntranceCardRepository
    {
        public EntranceCardRepository(EacmmDBContext dbContext) : base(dbContext)
        {
        }
    }
}
