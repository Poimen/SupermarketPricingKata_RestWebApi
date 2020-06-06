using System.Threading.Tasks;
using AutoMapper;
using NSubstitute;
using NUnit.Framework;
using SupermarketApi.Common.DataProviders;
using SupermarketApi.Products;
using SupermarketApi.Products.FindProducts;
using SupermarketApi.Products.Mapping;

namespace SupermarketApi.Tests
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public async Task ProductsGet_GivenNoItems_ShouldReturnEmptyList()
        {
            // Arrange
            var controller = CreateController();
            // Act
            var result = await controller.Get();
            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public async Task ProductsGet_GivenItems_ShouldReturnListOfItems()
        {
            // Arrange
            var controller = CreateController();
            // Act
            var result = await controller.Get();
            // Assert
            Assert.That(result, Is.Empty);
        }

        private static ProductsController CreateController()
        {
            var findProducts = CreateFindProductsUseCase();
            var mapper = CreateMapper();

            return new ProductsController(mapper, findProducts);
        }

        private static IFindProducts CreateFindProductsUseCase()
        {
            var dataProvider = Substitute.For<IDataProvider>();
            return new FindProducts(dataProvider);
        }

        private static IMapper CreateMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductMapper>();
            });

            return config.CreateMapper();
        }
    }
}
