namespace ConsoleDecorator.Additions
{
    class Cheese : Pizza
    {
        private readonly Pizza pizza;
        public Cheese(Pizza pizza) => this.pizza = pizza;

        public override string Name => $"{pizza.Name} + {nameof(Cheese)}";
        public override int Cost => pizza.Cost + 5;
    }
}
