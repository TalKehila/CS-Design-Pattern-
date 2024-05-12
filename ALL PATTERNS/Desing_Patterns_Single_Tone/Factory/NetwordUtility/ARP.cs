using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.Factory.NetwordUtility
{
    internal class ARP :INetwork
    {
        public void SendRequsest(string ip, int timesSent)
        {
            Console.WriteLine($"ARP requst  send: {ip}  in time: {timesSent}");
        }
    }
}
