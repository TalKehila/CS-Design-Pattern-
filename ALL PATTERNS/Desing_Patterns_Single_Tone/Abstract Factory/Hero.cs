namespace Desing_Patterns.Abstract_Factory
{
    
    internal interface Hero 
    {
        Movement move { get; set; }
        string type { get; set; }

        void DisplayInfo();

    }
    class HeroElf : Hero
    {
        public string type { get; set; }
        public Movement move { get; set; }
        Attack attack;


        public HeroElf()
        {
            attack = new Attack();
            attack.weapon = new Bow();
            attack.move = new Fly();    
            type = "Elf";
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"I am an Elf Hero");       
            attack.DoAttack();
        }
    }
    class DwarfHero : Hero
    {
        public string type { get; set; }
        public Movement move { get; set; }
        Attack attack;
        public DwarfHero() 
        {
            attack = new Attack();
            attack.weapon = new Axe();
            attack.move = new Fly();

            type = "Dwarf";
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"I am a Dwarf Hero");
            attack.DoAttack();
            
        }
        
    }
}
