using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.Adapter.Network_client_
{
    internal class NetworkClient :INetworkClient
    {

        public void SendRequest(string ipAddress)
        {
            Console.WriteLine("network client request send to : " + ipAddress);
        }
    }
}
