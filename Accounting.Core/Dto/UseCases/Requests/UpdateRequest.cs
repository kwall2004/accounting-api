namespace Accounting.Core.Dto.UseCases.Requests
{
    public class UpdateRequest<TEntity>
    {
        public TEntity Value { get; }

        public UpdateRequest(TEntity value)
        {
            Value = value;
        }
    }
}
