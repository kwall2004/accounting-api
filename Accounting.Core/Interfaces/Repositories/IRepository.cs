using System.Collections.Generic;
using System.Threading.Tasks;

namespace Accounting.Core.Interfaces.Repositories
{
    public interface IRepository<TEntity, TId>
    {
        Task<TEntity> Create(TEntity entity);
        Task<IEnumerable<TEntity>> Read();
        Task<TEntity> ReadOne(TId id);
        Task<TEntity> Update(TEntity entity);
        Task Delete(TId id);
    }
}
