namespace Observer.Observers
{
    using System;
    using Observer.Base;

    public class MoneyFormatObserver : IObserver
    {
        public void NotifyObserver(string command, Object source)
        {
            if (command.Equals("moneyFormat"))
            {
                ConfigurationManager conf = (ConfigurationManager)source;
                Console.WriteLine("Observer ==> MoneyFormatObserver.moneyFormatChange > " + 1.11.ToString(conf.GetMoneyFormat()));
            }
        }
    }
}
