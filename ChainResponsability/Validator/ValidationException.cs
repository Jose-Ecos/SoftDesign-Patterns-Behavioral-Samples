namespace ChainResponsability.Validator
{

    using System;
    public class ValidationException : Exception
    {
        public ValidationException(String message) : base(message)
        {
        }
    }
}
