using Accounting.Core.Interfaces.Repositories;
using Accounting.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accounting.Infrastructure.Repositories
{
    public class Repository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : class
    {
        protected readonly AppDbContext _appDbContext;

        public Repository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            await _appDbContext.Set<TEntity>().AddAsync(entity);
            return entity;
        }

        public async Task<IEnumerable<TEntity>> Read()
        {
            return await Task.FromResult(_appDbContext.Set<TEntity>());
        }

        public async Task<TEntity> ReadOne(TId id)
        {
            return await _appDbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _appDbContext.Entry(entity).State = EntityState.Modified;
            return await Task.FromResult(entity);
        }

        public async Task Delete(TId id)
        {
            var entity = await _appDbContext.Set<TEntity>().FindAsync(id);
            _appDbContext.Set<TEntity>().Remove(entity);
        }
    }
}
