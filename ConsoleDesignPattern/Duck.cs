using ConsoleDesignPattern.Contracts;
using System;

namespace ConsoleDesignPattern
{
    public abstract class Duck
    {
        public IQuackBehavior _quackBehavior;
        public IFlyBehavior _flyBehavior;
        public Duck()
        {
                
        }

        public abstract void Display();

        public void PerformQuack()
        {
            _quackBehavior.quack();
        }

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public void setQuackBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }

        public void setFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }
    }
}
