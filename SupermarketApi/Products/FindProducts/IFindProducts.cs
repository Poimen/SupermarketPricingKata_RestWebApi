using System.Collections.Generic;
using SupermarketApi.Products.Models;

namespace SupermarketApi.Products.FindProducts
{
    public interface IFindProducts
    {
        IEnumerable<Product> All();
    }
}
