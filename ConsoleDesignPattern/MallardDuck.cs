using ConsoleDesignPattern.Abilities;
using System;

namespace ConsoleDesignPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _quackBehavior = new Quack();
            _flyBehavior = new FlyWithWings();
        }
        
        public override void Display()
        {
            Console.WriteLine("I'am a real Mallard Duck");
        }
    }
}
