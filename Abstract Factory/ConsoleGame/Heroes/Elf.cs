namespace ConsoleGame.Heroes
{
    class Elf : IHeroFactory
    {
        public IMovement CreateMovement() => new Fly();
        public IWeapon CreateWeapon() => new Bow();
    }
}