using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SupermarketApi.Products.Models;

namespace SupermarketApi.Products
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        public ProductsController()
        {
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return Enumerable.Empty<Product>();
        }
    }
}
