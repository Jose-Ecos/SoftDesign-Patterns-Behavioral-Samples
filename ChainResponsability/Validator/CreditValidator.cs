namespace ChainResponsability.Validator
{
    using ChainResponsability.Domain;
    using ChainResponsability.Domain.Order;

    public class CreditValidator : AbstractOrderValidator
    {

        public override void Validate(AbstractOrder order)
        {
            double total = order.getTotal();
            CreditData creditData = order.Contributor.CreditData;
            double newBalance = creditData.Balance + total;
            if (newBalance > creditData.CreditLimit)
            {
                throw new ValidationException("The amount of the order  " + "exceeds the available credit limit");
            }
        }
    }
}
