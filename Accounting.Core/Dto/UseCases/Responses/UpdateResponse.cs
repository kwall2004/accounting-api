namespace Accounting.Core.Dto.UseCases.Responses
{
    public class UpdateResponse<TEntity>
    {
        public TEntity Value { get; }

        public UpdateResponse(TEntity value)
        {
            Value = value;
        }
    }
}
