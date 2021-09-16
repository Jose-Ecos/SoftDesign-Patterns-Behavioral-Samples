namespace Observer.Base
{
    public class ConfigurationManager : AbstractObservable
    {
        private string DefaultDateFormat;
        private string MoneyFormat;
        private static ConfigurationManager ConfManager;

        private ConfigurationManager()
        {
        }

        public static ConfigurationManager GetInstance()
        {
            if (ConfManager == null)
            {
                ConfManager = new ConfigurationManager();
            }
            return ConfManager;
        }

        public string GetDefaultDateFormat()
        {
            return DefaultDateFormat;
        }

        public void setDefaultDateFormat(string defaultDateFormat)
        {
            this.DefaultDateFormat = defaultDateFormat;
            NotifyAllObservers("defaultDateFormat", this);
        }

        public string GetMoneyFormat()
        {
            return MoneyFormat;
        }

        public void SetMoneyFormat(string moneyFormat)
        {
            this.MoneyFormat = moneyFormat;
            NotifyAllObservers("moneyFormat", this);
        }
    }
}
