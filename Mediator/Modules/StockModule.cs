namespace Mediator.Modules
{
    using System;
    using Mediator.Base;
    using Mediator.Modules.Dtos;

    public class StockModule : AbstractModule
    {
        public static readonly string MODULE_NAME = "Stock";
        public const string OPERATION_DECREMENT_STOCK = "DecrementStock";

        public override string GetModulName()
        {
            return MODULE_NAME;
        }

        public override object NotifyMessage(ModuleMessage message)
        {
            switch (message.MessageType)
            {
                case OPERATION_DECREMENT_STOCK:
                    return decrementStock(message);
                default:
                    throw new SystemException("Operation not supported '" + message.MessageType + "'");
            }
        }

        private object decrementStock(ModuleMessage message)
        {
            SaleOrder saleOrder = (SaleOrder)message.Payload;
            foreach (Product product in saleOrder.Productos)
            {
                Console.WriteLine("decrement product > " + product.Name);
            }

            ProductRequest productRequest = new ProductRequest();
            productRequest.Products = saleOrder.Productos;

            ModuleMessage purchaseMessage = new ModuleMessage(MODULE_NAME, PurchaseModule.MODULE_NAME, PurchaseModule.OPERATION_PURCHASE_REQUEST, productRequest);
            Mediator.Mediate(purchaseMessage);
            return null;

        }
    }
}