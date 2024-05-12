namespace ConsoleGame.Heroes
{
    class Dwarf : IHeroFactory
    {
        public IMovement CreateMovement() => new Run();
        public IWeapon CreateWeapon() => new Axe();
    }
}