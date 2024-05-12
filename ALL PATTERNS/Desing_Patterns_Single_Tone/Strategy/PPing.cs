using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.Strategy
{
    internal class PPing : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("sending ping!");
        }
    }
}
