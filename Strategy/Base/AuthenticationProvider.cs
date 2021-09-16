namespace Strategy.Base
{
    using System;

    public class AuthenticationProvider
    {
        private IAuthenticationStrategy AuthenticationStrategy;

        public void SetAuthenticationStrategy(IAuthenticationStrategy strategy)
        {
            this.AuthenticationStrategy = strategy;
        }

        public Principal Authenticate(String userName, String password)
        {
            if (AuthenticationStrategy == null)
            {
                throw new SystemException("Strategy not found");
            }
            return AuthenticationStrategy.Authenticate(userName, password);
        }
    }
}
