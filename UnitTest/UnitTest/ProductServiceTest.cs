using ClassLibrary;
using NFluent;
using NSubstitute;
using System;
using Xunit;

namespace UnitTest
{
    public class ProductServiceTest
    {
        [Fact]
        public void Should_ShowPrice_When_PriceIsLow()
        {
            //Init
            var productRepository = Substitute.For<ProductRepository>();
            var productService = new ProductService(productRepository);
            var productId = Guid.NewGuid();

            var lowPrice = 100;
            productRepository.GetPrice(productId).Returns(lowPrice);

            //Action
            var priceToHighToShowToClient = productService.IsPriceToHighToShowItToClient(productId);

            //Check
            Check.That(priceToHighToShowToClient).IsFalse();
        }

        [Fact]
        public void Should_NotShowPrice_When_PriceIsHigh()
        {
            //Init
            var productRepository = Substitute.For<ProductRepository>();
            var productService = new ProductService(productRepository);
            var productId = Guid.NewGuid();

            var highPrice = 1000000;
            productRepository.GetPrice(productId).Returns(highPrice);

            //Action
            var priceToHighToShowToClient = productService.IsPriceToHighToShowItToClient(productId);

            //Check
            Check.That(priceToHighToShowToClient).IsTrue();
        }
    }
}
