using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.Adapter.Network_client_
{
    internal interface INetworkClient
    {
        void SendRequest(string ipAddress);    
    }
}
