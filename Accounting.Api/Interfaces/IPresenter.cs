using Accounting.Core.Dto.UseCases.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Accounting.Api.Interfaces
{
    public interface IPresenter<TEntity>
    {
        ContentResult Handle(CreateResponse<TEntity> response);
        ContentResult Handle(ReadResponse<TEntity> response);
        ContentResult Handle(ReadOneResponse<TEntity> response);
        ContentResult Handle(UpdateResponse<TEntity> response);
        ContentResult Handle(DeleteResponse response);
    }
}
