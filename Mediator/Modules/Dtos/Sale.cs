namespace Mediator.Modules.Dtos
{
    using System.Collections.Generic;

    public class Sale
    {
        public List<Product> Productos { get; set; }

        public Sale()
        {
            Productos = new List<Product>();
        }

        public void addProduct(Product product)
        {
            this.Productos.Add(product);
        }
    }
}
