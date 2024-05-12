using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.Strategy
{
    internal class DDns : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("sending DNS request!");
        }
    }
}
