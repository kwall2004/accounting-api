using Accounting.Core.Interfaces.Repositories;
using Accounting.Core.Interfaces.UnitsOfWork;
using Accounting.Infrastructure.Data;
using System.Threading.Tasks;

namespace Accounting.Infrastructure.UnitsOfWork
{
    public class UnitOfWork<TEntity, TId> : IUnitOfWork<TEntity, TId>
    {
        private readonly AppDbContext _dbContext;

        public IRepository<TEntity, TId> Repository { get; private set; }

        public UnitOfWork(IRepository<TEntity, TId> repository, AppDbContext dbContext)
        {
            Repository = repository;
            _dbContext = dbContext;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
