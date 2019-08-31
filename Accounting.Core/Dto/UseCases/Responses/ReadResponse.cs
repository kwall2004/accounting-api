using System.Collections.Generic;

namespace Accounting.Core.Dto.UseCases.Responses
{
    public class ReadResponse<TEntity>
    {
        public IEnumerable<TEntity> Value { get; }

        public ReadResponse(IEnumerable<TEntity> value)
        {
            Value = value;
        }
    }
}
