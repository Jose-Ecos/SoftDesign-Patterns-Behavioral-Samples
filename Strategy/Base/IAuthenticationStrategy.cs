namespace Strategy.Base
{
    public interface IAuthenticationStrategy
    {
        Principal Authenticate(string userName, string passwrd);
    }
}
