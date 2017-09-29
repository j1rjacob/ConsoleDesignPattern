using ConsoleDesignPattern.Contracts;
using System;

namespace ConsoleDesignPattern.Abilities
{
    public class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
