using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketApi.Common.DataProviders
{
    public class InMemoryDataProvider : IDataProvider
    {
        public InMemoryDataProvider()
        {

        }

        public Task<IEnumerable<T>> Select<T>(object query, object? parameters = null)
        {
            return Task.FromResult(Enumerable.Empty<T>());
        }
    }
}
