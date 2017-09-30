namespace DecoratorPattern.Condiments
{
    public class Whip : Decorator
    {
        public Whip(BeverageComponent beverageComponent) : base(beverageComponent)
        {
            _description = "Whip";
            _cost = .10m;
        }
    }
}
