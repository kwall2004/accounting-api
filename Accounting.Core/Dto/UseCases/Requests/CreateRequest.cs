namespace Accounting.Core.Dto.UseCases.Requests
{
    public class CreateRequest<TEntity>
    {
        public TEntity Value { get; }

        public CreateRequest(TEntity value)
        {
            Value = value;
        }
    }
}
