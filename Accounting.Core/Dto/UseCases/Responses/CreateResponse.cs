namespace Accounting.Core.Dto.UseCases.Responses
{
    public class CreateResponse<TEntity>
    {
        public TEntity Value { get; }

        public CreateResponse(TEntity value)
        {
            Value = value;
        }
    }
}
