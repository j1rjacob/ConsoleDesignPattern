namespace DecoratorPattern.Coffees
{
    public class HouseBlend : Decorator
    {
        public HouseBlend(BeverageComponent beverageComponent) : base(beverageComponent)
        {
            _description = "House Blend";
            _cost = .89m;
        }
    }
}
