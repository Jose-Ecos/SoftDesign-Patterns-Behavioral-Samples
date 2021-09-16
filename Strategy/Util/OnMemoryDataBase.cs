using System.Collections.Generic;

namespace Strategy.Util
{
    public class OnMemoryDataBase
    {
        private static readonly Dictionary<string, User> USER_MAP = new Dictionary<string, User>();

        static OnMemoryDataBase()
        {
            USER_MAP.Add("jecos", new User("jecos", "1234", "Admin"));
            USER_MAP.Add("rlopez", new User("rlopez", "2345", "Cajero"));
            USER_MAP.Add("lcastro", new User("lcastro", "2345", "Supervisor"));
        }

        public static User FindUserByName(string name)
        {
            if (USER_MAP.ContainsKey(name))
            {
                return USER_MAP[name];
            }
            return null;
        }
    }
}
