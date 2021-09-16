namespace ChainResponsability.Validator
{
    using System.Collections.Generic;
    using ChainResponsability.Domain.Order;    

    public abstract class AbstractOrderValidator
    {

        protected List<AbstractOrderValidator> Validators = new List<AbstractOrderValidator>();

        public abstract void Validate(AbstractOrder order);

        public void AddValidator(AbstractOrderValidator validator)
        {
            Validators.Add(validator);
        }
    }
}
