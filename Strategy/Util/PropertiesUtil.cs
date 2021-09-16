namespace Strategy.Util
{
    using System;
    using System.Collections.Specialized;
    using System.Configuration;

    public class PropertiesUtil
    {
        public static NameValueCollection LoadProperty()
        {
            try
            {
                NameValueCollection props = ConfigurationManager.AppSettings;
                return props;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
