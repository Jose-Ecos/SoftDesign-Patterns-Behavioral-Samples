namespace ChainResponsability.Validator
{
    using ChainResponsability.Domain.Order;

    public class SalesOrderValidator : AbstractOrderValidator
    {
        public override void Validate(AbstractOrder order)
        {
            if (!(order.GetType() == typeof(SalesOrder)))
            {
                throw new ValidationException("A sales order was expected");
            }

            foreach (AbstractOrderValidator validator in Validators)
            {
                validator.Validate(order);
            }
        }
    }
}
