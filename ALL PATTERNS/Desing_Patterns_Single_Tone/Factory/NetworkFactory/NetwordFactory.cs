using Desing_Patterns.Factory.NetwordUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.Factory.NetworkFactory
{
    internal class NetwordFactory
    {
        public INetwork GetNetworkInstance(string type)
        {
            INetwork obj = null;
            if (type.ToLower().Equals("ping"))
            {
                obj = new Ping();
            }
            else if (type.ToLower().Equals("dns"))
            {
                obj= new DNS();
            }
            else if (type.ToLower().Equals("arp"))
            {
                obj= new ARP();
            }
            else
            {
                Console.WriteLine("Type not Found");
            }
            return obj;


        }
    }
}
