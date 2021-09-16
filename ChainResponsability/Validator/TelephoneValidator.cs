namespace ChainResponsability.Validator
{
    using ChainResponsability.Domain;
    using ChainResponsability.Domain.Order;

    public class TelephoneValidator : AbstractOrderValidator
    {
        public override void Validate(AbstractOrder order)
        {
            Telephone tel = order.Contributor.Telephone;
            if (null == tel)
            {
                throw new ValidationException("The taxpayer's phone is required");
            }
            else if (tel.Number.Length != 7)
            {
                throw new ValidationException("Invalid phone number");
            }
            else if (tel.Lada.Length != 3)
            {
                throw new ValidationException("Invalid lada");
            }
        }
    }
}
