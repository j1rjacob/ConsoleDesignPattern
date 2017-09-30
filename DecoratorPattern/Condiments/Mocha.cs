namespace DecoratorPattern.Condiments
{
    public class Mocha : Decorator
    {
        public Mocha(BeverageComponent beverageComponent) : base(beverageComponent)
        {
            _description = "Mocha";
            _cost = .20m;
        }
    }
    
}
