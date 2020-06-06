using System.Collections.Generic;
using System.Linq;

namespace SupermarketApi.Common.DataProviders
{
    public class InMemoryDataProvider : IDataProvider
    {
        public InMemoryDataProvider()
        {

        }

        public IEnumerable<T> Select<T>(object query, object parameters = null)
        {
            return Enumerable.Empty<T>();
        }
    }
}
