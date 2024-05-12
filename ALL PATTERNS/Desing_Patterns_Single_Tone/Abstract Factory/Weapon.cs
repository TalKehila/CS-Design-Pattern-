using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.Abstract_Factory
{
    internal abstract class Weapon
    {
        public string type { get; set; }
        public abstract void DisplayWeapon();
    }
    class Bow : Weapon
    {
        public Bow( )
        {
            type = "Bow";        
        }
        public override void DisplayWeapon()
        {
            Console.WriteLine("im using Bow as a weapon ");
        }
    }

    class Axe :Weapon
    {
        public Axe()
        {
            type = "Axe";
        
        }
        public override void DisplayWeapon()
        {
            Console.WriteLine("im using Axe as Weapon");
        }
    }
}
