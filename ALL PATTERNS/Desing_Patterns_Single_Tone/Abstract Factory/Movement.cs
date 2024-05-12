using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.Abstract_Factory
{
    internal interface Movement
    {      
        void DisplayMove();
    }
    class Fly : Movement
    {            
        public  void DisplayMove() => Console.WriteLine("Im flying");           
    }
    class Run : Movement
    {
        public  void DisplayMove() =>Console.WriteLine("Im Running");                    
    }
}
