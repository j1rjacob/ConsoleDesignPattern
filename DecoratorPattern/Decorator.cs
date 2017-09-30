namespace DecoratorPattern
{
    public abstract class Decorator : BeverageComponent
    {
        protected BeverageComponent _beverageComponent;
        protected string _description ="";
        protected decimal _cost = 0m;
        
        protected Decorator(BeverageComponent beverageComponent)
        {
            _beverageComponent = beverageComponent;
        }

        public override string Description
        {
            get { return string.Format("{0},{1}", _beverageComponent.Description, _description); }
        }

        public override decimal Cost
        {
            get { return _beverageComponent.Cost + _cost; }
        }

        public virtual BeverageComponent InnerComponent
        {
            get { return _beverageComponent; }
        }
    }
}
