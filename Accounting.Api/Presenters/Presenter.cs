using Accounting.Api.Interfaces;
using Accounting.Core.Dto.UseCases.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Accounting.Api.Presenters
{
    public class Presenter<TEntity> : IPresenter<TEntity>
    {
        public ContentResult Handle(CreateResponse<TEntity> response)
        {
            return new JsonContentResult
            {
                StatusCode = (int)HttpStatusCode.Created,
                Content = JsonSerializer.SerializeObject(response.Value)
            };
        }

        public ContentResult Handle(ReadResponse<TEntity> response)
        {
            return new JsonContentResult()
            {
                StatusCode = (int)HttpStatusCode.OK,
                Content = JsonSerializer.SerializeObject(response.Value)
            };
        }

        public ContentResult Handle(ReadOneResponse<TEntity> response)
        {
            return new JsonContentResult()
            {
                StatusCode = (int)HttpStatusCode.OK,
                Content = JsonSerializer.SerializeObject(response.Value)
            };
        }

        public ContentResult Handle(UpdateResponse<TEntity> response)
        {
            return new JsonContentResult()
            {
                StatusCode = (int)HttpStatusCode.OK,
                Content = JsonSerializer.SerializeObject(response.Value)
            };
        }

        public ContentResult Handle(DeleteResponse response)
        {
            return new JsonContentResult
            {
                StatusCode = (int)HttpStatusCode.NoContent
            };
        }
    }
}
