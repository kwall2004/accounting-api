using Accounting.Core.Dto.UseCases.Requests;
using Accounting.Core.Dto.UseCases.Responses;
using Accounting.Core.Interfaces.UnitsOfWork;
using Accounting.Core.Interfaces.UseCases;
using System.Threading.Tasks;

namespace Accounting.Core.UseCases
{
    public class UseCase<TEntity, TId> : IUseCase<TEntity, TId>
    {
        protected readonly IUnitOfWork<TEntity, TId> _unitOfWork;

        public UseCase(IUnitOfWork<TEntity, TId> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public virtual async Task<CreateResponse<TEntity>> Handle(CreateRequest<TEntity> request)
        {
            var entity = await _unitOfWork.Repository.Create(request.Value);
            await _unitOfWork.SaveChangesAsync();

            return new CreateResponse<TEntity>(entity);
        }

        public virtual async Task<ReadResponse<TEntity>> Handle(ReadRequest request)
        {
            return new ReadResponse<TEntity>(await _unitOfWork.Repository.Read());
        }

        public virtual async Task<ReadOneResponse<TEntity>> Handle(ReadOneRequest<TId> request)
        {
            return new ReadOneResponse<TEntity>(await _unitOfWork.Repository.ReadOne(request.Id));
        }

        public virtual async Task<UpdateResponse<TEntity>> Handle(UpdateRequest<TEntity> request)
        {
            var entity = await _unitOfWork.Repository.Update(request.Value);
            await _unitOfWork.SaveChangesAsync();

            return new UpdateResponse<TEntity>(entity);
        }

        public virtual async Task<DeleteResponse> Handle(DeleteRequest<TId> request)
        {
            await _unitOfWork.Repository.Delete(request.Id);
            await _unitOfWork.SaveChangesAsync();

            return new DeleteResponse();
        }
    }
}
