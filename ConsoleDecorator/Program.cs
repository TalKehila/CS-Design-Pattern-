using ConsoleDecorator.Additions;
using ConsoleDecorator.Bases;

namespace ConsoleDecorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Italian();
            pizza = new Tomato(pizza);
            pizza = new Tomato(pizza);
            PrintCheck(pizza);

            Pizza pizzaB = new Bulgarian();
            pizzaB = new Cheese(pizzaB);
            pizzaB = new Tomato(pizzaB);
            PrintCheck(pizzaB);

            Pizza pizzaC = new Bulgarian();
            pizzaC = new Italian();
            pizzaC = new Tomato(pizzaC);
            PrintCheck(pizzaC);
        }

        private static void PrintCheck(Pizza pizza) => Console.WriteLine($"{pizza.Name}: {pizza.Cost} ");
    }
}
