using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.Factory.NetwordUtility
{
    internal class DNS : INetwork
    {
        public void SendRequsest(string ip, int timesSent)
        {
            Console.WriteLine($"DNS requst  send: {ip}  in time: {timesSent}");
        }
    }
}
