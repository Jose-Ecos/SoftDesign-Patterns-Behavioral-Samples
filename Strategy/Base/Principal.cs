namespace Strategy.Base
{
    public class Principal
    {
        public string UserName { get; set; }
        public string Rol { get; set; }

        public Principal(string UserName, string Rol)
        {
            this.UserName = UserName;
            this.Rol = Rol;
        }

        public override string ToString()
        {
            return "Principal{" + "userName=" + UserName + ", rol=" + Rol + '}';
        }
    }
}
