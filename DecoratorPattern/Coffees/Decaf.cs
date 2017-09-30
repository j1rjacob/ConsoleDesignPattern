namespace DecoratorPattern.Coffees
{
    public class Decaf : Decorator
    {
        public Decaf(BeverageComponent beverageComponent) : base(beverageComponent)
        {
            _description = "Decaf";
            _cost = 1.05m;
        }
    }
}
