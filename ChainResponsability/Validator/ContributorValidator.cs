namespace ChainResponsability.Validator
{
    using ChainResponsability.Domain;
    using ChainResponsability.Domain.Order;

    public class ContributorValidator : AbstractOrderValidator
    {
        public override void Validate(AbstractOrder order)
        {
            foreach (AbstractOrderValidator validator in Validators)
            {
                validator.Validate(order);
            }
            Contributor contributor = order.Contributor;
            if (Status.ACTIVO != contributor.Status)
            {
                throw new ValidationException("The taxpayer is not active");
            }
        }
    }
}
