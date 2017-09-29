using ConsoleDesignPattern.Abilities;
using System;

namespace ConsoleDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mallard Duck");
            var mallardDuck = new MallardDuck();

            mallardDuck.Display();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
            mallardDuck.Swim();

            Console.WriteLine("\nModel Duck");
            var modelDuck = new ModelDuck();
            modelDuck.PerformFly();
            modelDuck.setFlyBehavior(new FlyRocketPowered());
            modelDuck.PerformFly();

            Console.ReadLine();
        }
    }
}
