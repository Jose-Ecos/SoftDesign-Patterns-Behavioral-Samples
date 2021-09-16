namespace ChainResponsability.Domain.Order
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public double Price { get; set; }
        public float Quantity { get; set; }

        public double getTotal()
        {
            return Price * Quantity;
        }
    }
}
