namespace ChainResponsability.Domain.Order
{
    using System;

    public class SalesOrder : AbstractOrder
    {
        public DateTime DeliveryDate { get; set; }

    }
}
