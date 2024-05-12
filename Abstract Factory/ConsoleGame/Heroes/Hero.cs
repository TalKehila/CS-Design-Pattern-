namespace ConsoleGame.Heroes
{
    class Hero
    {
        readonly IMovement movement;
        readonly IWeapon weapon;
        public Hero(IHeroFactory heroFactory)
        {
            movement = heroFactory.CreateMovement();
            weapon = heroFactory.CreateWeapon();
        }
        public void Attack()
        {
            movement.Move();
            weapon.Damage();
        }
    }
}