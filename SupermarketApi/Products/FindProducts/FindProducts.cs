using System;
using System.Collections.Generic;
using System.Linq;
using SupermarketApi.Common.DataProviders;
using SupermarketApi.Products.Models;

namespace SupermarketApi.Products.FindProducts
{
    public class FindProducts : IFindProducts
    {
        private readonly IDataProvider _dbProvider;

        public FindProducts(IDataProvider dbProvider)
        {
            _dbProvider = dbProvider ?? throw new ArgumentNullException(nameof(dbProvider));
        }

        public IEnumerable<Product> All()
        {
            return _dbProvider.Select<Product>(null);
        }
    }
}
