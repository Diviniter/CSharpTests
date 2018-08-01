using System;

namespace ClassLibrary
{
    public class ProductService
    {
        private readonly ProductRepository productRepository;

        public ProductService(ProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public bool IsPriceToHighToShowItToClient(Guid productId)
        {
            var productPrice = this.productRepository.GetPrice(productId);

            return productPrice >= 1000000;
        }
    }
}
