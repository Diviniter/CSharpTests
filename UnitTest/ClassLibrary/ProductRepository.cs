using System;

namespace ClassLibrary
{
    public interface ProductRepository
    {
        decimal GetPrice(Guid productId);
    }
}
