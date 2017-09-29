using ConsoleDesignPattern.Contracts;
using System;

namespace ConsoleDesignPattern.Abilities
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
