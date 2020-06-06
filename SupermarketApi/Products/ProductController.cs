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

        public async Task<Product> Index()
        {
            throw new System.NotImplementedException();
        }
    }
}
