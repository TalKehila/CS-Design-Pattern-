namespace ConsoleGame.Weapons
{
    class Bow : IWeapon
    {
        public void Damage() => Console.WriteLine("Damage by Bow = 12");
    }
}