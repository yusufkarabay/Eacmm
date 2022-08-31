using Eacmm.Core.Entities.Abstract;
using Eacmm.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Repositories.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly EacmmDBContext _dbContext;
        protected virtual IQueryable<T> _dbset => _dbContext.Set<T>().AsNoTracking();
        public GenericRepository(EacmmDBContext dbContext)
        {
            _dbContext=dbContext;
        }
    
        public async Task AddAsync(T entity)
        {
           await _dbContext.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid id)
        {
            return _dbset.Where(x => x.Id==id).FirstOrDefaultAsync();
        }

        public async Task Update(T entity)
        {

            entity.LastModifiedAt = DateTime.UtcNow;

            var notUpdateCreatedAt = await GetByIdAsync(entity.Id);

            entity.CreatedAt=notUpdateCreatedAt.CreatedAt;
            try
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
            }
            catch (InvalidOperationException iex)
            {
                if (!iex.Message.Contains("already being tracked"))
                {
                    throw;
                }
            }
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(T entity)
        {
            entity.LastModifiedAt = DateTime.UtcNow;

            var notUpdateCreatedAt = await GetByIdAsync(entity.Id);

            entity.CreatedAt=notUpdateCreatedAt.CreatedAt;
            try
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
            }
            catch (InvalidOperationException iex)
            {
                if (!iex.Message.Contains("already being tracked"))
                {
                    throw;
                }
            }
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return _dbset.Where(m => m.Id == id).FirstOrDefault() != null;
        }

        public async Task<List<T>> GetByIdListAsync(Guid id)
        {
           return await _dbset.Where(m => m.Id == id).ToListAsync();    
        }
    }
}
