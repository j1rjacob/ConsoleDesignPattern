namespace DecoratorPattern
{
    public abstract class BeverageComponent 
    {
        public abstract string Description { get; }
        public abstract decimal Cost { get; }
    }
}
