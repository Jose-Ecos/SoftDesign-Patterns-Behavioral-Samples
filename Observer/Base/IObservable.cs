using System;

namespace Observer.Base
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);

        void RemoveObserver(IObserver observer);

        void NotifyAllObservers(string command, Object source);
    }
}
