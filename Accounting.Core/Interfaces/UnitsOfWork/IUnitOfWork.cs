using Accounting.Core.Interfaces.Repositories;
using System.Threading.Tasks;

namespace Accounting.Core.Interfaces.UnitsOfWork
{
    public interface IUnitOfWork<TEntity, TId>
    {
        IRepository<TEntity, TId> Repository { get; }
        Task<int> SaveChangesAsync();
    }
}
