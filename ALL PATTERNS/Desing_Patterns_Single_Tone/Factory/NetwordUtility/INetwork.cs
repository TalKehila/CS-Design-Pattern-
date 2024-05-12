using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.Factory.NetwordUtility
{
    internal interface INetwork
    {
      void  SendRequsest(string ip, int timesSent);
       
    }
}
