using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.ChainOfResponsibility
{
    internal interface Ichain
    {
        void SendRequest(NetworkModel request);
        void SetNext(Ichain nextChain);
    }
}
