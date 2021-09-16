namespace Observer.Base
{
    using System;

    public interface IObserver
    {
        void NotifyObserver(string command, Object source);
    }
}
