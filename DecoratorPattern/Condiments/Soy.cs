namespace DecoratorPattern.Condiments
{
    public class Soy : Decorator
    {
        public Soy(BeverageComponent beverageComponent) : base(beverageComponent)
        {
            _description = "Soy";
            _cost = .15m;
        }
    }
}
