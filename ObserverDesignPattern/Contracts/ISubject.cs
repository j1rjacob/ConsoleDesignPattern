namespace ObserverDesignPattern.Contracts
{
    public interface ISubject
    {
        void RegisterObserver(IObserver register);
        void RemoveObserver(IObserver remove);
        void NotifyObservers();
    }
}
