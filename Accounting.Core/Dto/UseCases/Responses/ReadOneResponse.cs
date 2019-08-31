namespace Accounting.Core.Dto.UseCases.Responses
{
    public class ReadOneResponse<TEntity>
    {
        public TEntity Value { get; }

        public ReadOneResponse(TEntity value)
        {
            Value = value;
        }
    }
}
