﻿namespace ObserverDesignPattern.Contracts
{
    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}
