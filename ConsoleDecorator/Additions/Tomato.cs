namespace ConsoleDecorator.Additions
{
    class Tomato : Pizza
    {
        private readonly Pizza pizza;
        public Tomato(Pizza pizza) => this.pizza = pizza;

        public override string Name => $"{pizza.Name} + {nameof(Tomato)}";
        public override int Cost => pizza.Cost + 3;
    }
}
