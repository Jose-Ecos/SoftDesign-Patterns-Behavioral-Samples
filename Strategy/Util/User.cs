namespace Strategy.Util
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }

        public User(string UserName, string Password, string Rol)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Rol = Rol;
        }
    }
}
