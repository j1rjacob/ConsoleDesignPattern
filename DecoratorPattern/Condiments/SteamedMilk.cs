namespace DecoratorPattern.Condiments
{
    public class SteamedMilk : Decorator
    {
        public SteamedMilk(BeverageComponent beverageComponent) : base(beverageComponent)
        {
            _description = "Steamed Milk";
            _cost = .10m;
        }
    }
}
