namespace Accounting.Core.Dto.UseCases.Requests
{
    public class ReadOneRequest<TId>
    {
        public TId Id { get; }

        public ReadOneRequest(TId id)
        {
            Id = id;
        }
    }
}
