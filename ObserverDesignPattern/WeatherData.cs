using ObserverDesignPattern.Contracts;
using System.Collections;

namespace ObserverDesignPattern
{
    public class WeatherData : ISubject
    {
        private ArrayList _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new ArrayList();
        }

        public void RegisterObserver(IObserver register)
        {
            _observers.Add(register);
        }

        public void RemoveObserver(IObserver remove)
        {
            int i = _observers.IndexOf(remove);
            if(i>=0)
                _observers.Remove(i);
        }

        public void NotifyObservers()
        {
            foreach (var item in _observers)
            {
                var observer = (IObserver) item;
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void MeasurementChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementChanged();
        }
    }
}
