namespace DecoratorPattern.Coffees
{
    public class DarkRoast : Decorator
    {
        public DarkRoast(BeverageComponent beverageComponent) : base(beverageComponent)
        {
            _description = "Dark Roast";
            _cost=.99m;
        }
    }
}
