using System.Collections.Generic;
using System.Threading.Tasks;
using SupermarketApi.Products.Models;

namespace SupermarketApi.Products.FindProducts
{
    public interface IFindProducts
    {
        Task<IEnumerable<Product>> All();
    }
}
