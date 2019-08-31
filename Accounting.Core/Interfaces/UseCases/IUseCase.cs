using Accounting.Core.Dto.UseCases.Requests;
using Accounting.Core.Dto.UseCases.Responses;
using System.Threading.Tasks;

namespace Accounting.Core.Interfaces.UseCases
{
    public interface IUseCase<TEntity, TId>
    {
        Task<CreateResponse<TEntity>> Handle(CreateRequest<TEntity> request);
        Task<ReadResponse<TEntity>> Handle(ReadRequest request);
        Task<ReadOneResponse<TEntity>> Handle(ReadOneRequest<TId> request);
        Task<UpdateResponse<TEntity>> Handle(UpdateRequest<TEntity> request);
        Task<DeleteResponse> Handle(DeleteRequest<TId> request);
    }
}
