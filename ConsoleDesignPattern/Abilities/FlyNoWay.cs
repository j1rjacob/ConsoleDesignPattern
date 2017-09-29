using ConsoleDesignPattern.Contracts;
using System;

namespace ConsoleDesignPattern.Abilities
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!");
        }
    }
}
