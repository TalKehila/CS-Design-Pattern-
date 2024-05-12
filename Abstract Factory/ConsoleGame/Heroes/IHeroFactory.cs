namespace ConsoleGame.Heroes
{
    interface IHeroFactory
    {
        IMovement CreateMovement();
        IWeapon CreateWeapon();
    }
}