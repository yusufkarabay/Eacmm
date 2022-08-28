using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Repositories
{
    public class EacmmDbContext:DbContext
    {
        public EacmmDbContext(DbContextOptions<EacmmDbContext> dbContextOptions):base(dbContextOptions) 
        {

        }
    }
}
