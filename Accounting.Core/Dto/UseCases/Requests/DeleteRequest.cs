namespace Accounting.Core.Dto.UseCases.Requests
{
    public class DeleteRequest<TId>
    {
        public TId Id { get; }

        public DeleteRequest(TId id)
        {
            Id = id;
        }
    }
}
