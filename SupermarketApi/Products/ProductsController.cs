using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SupermarketApi.Products.Models;

namespace SupermarketApi.Products
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        public ProductController()
        {
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Index()
        {
            return Enumerable.Empty<Product>();
        }
    }
}
