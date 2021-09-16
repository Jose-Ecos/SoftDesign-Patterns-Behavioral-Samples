namespace Strategy.Providers
{
    using System;
    using System.Data;
    using System.Data.Common;
    using Strategy.Base;
    using Strategy.Util;

    public class SQLAuthenticationProvider : IAuthenticationStrategy
    {
        private static readonly string USER_QUERY = "SELECT userName,rol from users where userName='{0}' and password = '{1}'";
        private MySQLDBAdapter MysqlAdapter;

        public SQLAuthenticationProvider()
        {
            MysqlAdapter = new MySQLDBAdapter();
        }

        public Principal Authenticate(string user, string passwrd)
        {
            try
            {
                string queryUser = string.Format(USER_QUERY, user, passwrd);

                DbConnection connection = MysqlAdapter.GetConnection();
                DbCommand statement = connection.CreateCommand();
                statement.CommandText = queryUser;
                statement.CommandType = CommandType.Text;
                DbDataReader query = statement.ExecuteReader();

                Principal principal = null;
                Console.WriteLine(query.HasRows);
                while (query.Read())
                {
                    principal = new Principal((string)query["userName"], (string)query["rol"]);
                }
                query.Close();
                connection.Close();
                return principal;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }

        }
    }
}
