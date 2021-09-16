namespace Mediator.Modules.Dtos
{
    using System.Collections.Generic;

    public class ProductRequest
    {
        public List<Product> Products;

        public ProductRequest()
        {
            this.Products = new List<Product>();
        }
    }
}
