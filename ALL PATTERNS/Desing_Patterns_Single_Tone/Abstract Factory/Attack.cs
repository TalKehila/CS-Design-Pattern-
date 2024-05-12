using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.Abstract_Factory
{
    internal class Attack
    {
       public Movement move { get; set; }
       public Weapon weapon { get; set; }

       public void DoAttack()
        {
            move.DisplayMove();
            weapon.DisplayWeapon();       
        }

    }
}
