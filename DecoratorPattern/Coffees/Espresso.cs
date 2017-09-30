namespace DecoratorPattern.Coffees
{
    public class Espresso : Decorator
    {
        public Espresso(BeverageComponent beverageComponent) : base(beverageComponent)
        {
            _description = "Espresso";
            _cost = 1.99m;
        }
    }
}
