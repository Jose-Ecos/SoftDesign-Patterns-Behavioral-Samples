namespace Strategy.Providers
{    
    using System;
    using System.Xml;
    using Strategy.Base;

    public class XMLAuthenticationProvider : IAuthenticationStrategy
    {

        private static readonly string RolXPath = "descendant::User[@userName='{0}' and @password='{1}']/@rol";
        public Principal Authenticate(string userName, string passwrd)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("./UserFile.xml");
                XmlNode root = doc.DocumentElement;
                XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);

                string xpath = string.Format(RolXPath, userName, passwrd);
                XmlNode node = root.SelectSingleNode(xpath, nsmgr);
                if (node == null)
                {
                    return null;
                }
                string rol = node.InnerXml;
                if (rol != null && !(rol.Length == 0))
                {
                    return new Principal(userName, rol);
                }
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
