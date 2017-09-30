using DecoratorPattern.Coffees;
using DecoratorPattern.Condiments;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var beverage = new BaseBeverage();
            var beverage1 = new Espresso(beverage);
            Console.WriteLine(beverage1.Description+" $"+ beverage1.Cost+"\n");

            var beverage2 = new DarkRoast(beverage);
            var mocha1 = new Mocha(beverage2);
            var mocha2 = new Mocha(mocha1);
            var whip = new Whip(mocha2);
            Console.WriteLine(whip.Description + " $" + whip.Cost + "\n");

            var beverage3 = new HouseBlend(beverage);
            var soy = new Soy(beverage3);
            var mocha = new Mocha(soy);
            var whip1 = new Whip(mocha);
            Console.WriteLine(whip1.Description + " $" + whip1.Cost + "\n");

            Console.ReadLine();
        }
    }
}
