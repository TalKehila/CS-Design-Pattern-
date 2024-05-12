using ConsoleGame.Heroes;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var elf = new Hero(new Elf());
            var dwarf = new Hero(new Dwarf());

            var heroes = new List<Hero> { elf, dwarf };
            heroes.ForEach(h => h.Attack());
        }
    }
}