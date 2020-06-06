using System.Threading.Tasks;
using NUnit.Framework;
using SupermarketApi.Products;

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

        private static ProductsController CreateController()
        {
            return new ProductsController();
        }
    }
}
