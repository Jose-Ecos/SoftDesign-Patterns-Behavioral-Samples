namespace Observer.Observers
{
    using Observer.Base;
    using System;

    public class DateFormatObserver : IObserver
    {
        public void NotifyObserver(string command, object source)
        {
            if (command.Equals("defaultDateFormat"))
            {
                ConfigurationManager conf = (ConfigurationManager)source;
                Console.WriteLine("Observer ==> DateFormatObserver.dateFormatChange > " + DateTime.Now.ToString(conf.GetDefaultDateFormat()));
            }
        }
    }
}
