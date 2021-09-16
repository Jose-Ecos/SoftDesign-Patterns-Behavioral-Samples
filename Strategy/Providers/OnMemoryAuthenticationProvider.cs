namespace Strategy.Providers
{
    using Strategy.Base;
    using Strategy.Util;

    public class OnMemoryAuthenticationProvider : IAuthenticationStrategy
    {
        public Principal Authenticate(string userName, string passwrd)
        {
            User user = OnMemoryDataBase.FindUserByName(userName);
            if (user != null && user.Password.Equals(passwrd))
            {
                return new Principal(user.UserName, user.Rol);
            }
            return null;
        }
    }
}
