namespace ChainResponsability.Validator
{
    using ChainResponsability.Domain;
    using ChainResponsability.Domain.Order;

    public class CustomerValidator : AbstractOrderValidator
    {
        public override void Validate(AbstractOrder order)
        {
            foreach (AbstractOrderValidator validator in Validators)
            {
                validator.Validate(order);
            }            

            if (!(order.Contributor.GetType() == typeof(Customer)))
            {
                throw new ValidationException("The taxpayer is not a client");
            }
        }
    }
}
