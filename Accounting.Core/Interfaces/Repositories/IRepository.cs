using System.Collections.Generic;

namespace Accounting.Core.Interfaces.Repositories
{
    public interface IRepository<TEntity>
    {
        TEntity Create(TEntity entity);
        IEnumerable<TEntity> Read();
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
