namespace ConsoleDecorator
{
    abstract class Pizza
    {
        public virtual string Name => GetType().Name;
        public virtual int Cost { get; protected set; }
    }
}
