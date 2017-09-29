using ConsoleDesignPattern.Abilities;
using System;

namespace ConsoleDesignPattern
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _quackBehavior = new Quack();
            _flyBehavior = new FlyNoWay();
        }
        public override void Display()
        {
            Console.WriteLine("I'am a model duck");
        }
    }
}
