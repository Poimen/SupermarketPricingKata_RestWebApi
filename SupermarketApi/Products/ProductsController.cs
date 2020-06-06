using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SupermarketApi.Products.FindProducts;
using SupermarketApi.Products.Models;

namespace SupermarketApi.Products
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IFindProducts _findProducts;

        public ProductsController(IMapper mapper, IFindProducts findProducts)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _findProducts = findProducts ?? throw new ArgumentNullException(nameof(findProducts));
        }

        [HttpGet]
        public async Task<IEnumerable<ProductViewModel>> Get()
        {
            var allProducts = _findProducts.All();
            return this._mapper.Map<IEnumerable<ProductViewModel>>(allProducts);
        }
    }
}
