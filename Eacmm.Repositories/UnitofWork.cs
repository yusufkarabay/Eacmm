using Eacmm.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Repositories
{
    public class UnitofWork:IUnitofWork
    {
        private readonly EacmmDBContext _eacmmDbContext;
        public UnitofWork(EacmmDBContext eacmmDbContext)
        {
            _eacmmDbContext=eacmmDbContext; 
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _eacmmDbContext.SaveChangesAsync();
        }
    }
}
