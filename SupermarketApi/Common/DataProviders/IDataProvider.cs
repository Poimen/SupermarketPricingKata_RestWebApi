using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupermarketApi.Common.DataProviders
{
    public interface IDataProvider
    {
        Task<IEnumerable<T>> Select<T>(object query, object? parameters = null);
    }
}
