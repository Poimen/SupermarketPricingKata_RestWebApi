using System.Collections.Generic;

namespace SupermarketApi.Common.DataProviders
{
    public interface IDataProvider
    {
        IEnumerable<T> Select<T>(object query, object parameters = null);
    }
}
