using AutoMapper;
using SupermarketApi.Products.Models;

namespace SupermarketApi.Products.Mapping
{
    public class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<Product, ProductViewModel>();
        }
    }
}
