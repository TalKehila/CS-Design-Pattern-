using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.Factory.NetwordUtility
{
    internal class Ping : INetwork
    {

        public void SendRequsest(string ip , int timesSent)
        {
            Console.WriteLine($"ping requst  send: { ip}  in time: { timesSent}");
        }
    }
}
