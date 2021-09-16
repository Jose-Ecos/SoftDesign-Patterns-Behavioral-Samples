namespace Mediator
{
    using Mediator.Modules;
    using Mediator.Modules.Dtos;

    class Program
    {
        static void Main(string[] args)
        {
            new CRMModule().Activate();
            new NotifyModule().Activate();
            new StockModule().Activate();
            new PurchaseModule().Activate();

            ECommerceModule client = new ECommerceModule();
            client.Activate();

            Sale sale = new Sale();
            for (int c = 0; c < 5; c++)
            {
                sale.addProduct(new Product("Product" + (c + 1)));
            }
            client.createSale(sale);
        }
    }
}
