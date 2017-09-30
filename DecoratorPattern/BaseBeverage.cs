namespace DecoratorPattern
{
    public class BaseBeverage : BeverageComponent
    {
        public string _name = "";
        public decimal _cost = 0.00m;

        public override string Description
        {
            get { return _name; }
        }

        public override decimal Cost
        {
            get { return _cost; }
        }
    }
}
