using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.ChainOfResponsibility
{
    internal class SendSSH : Ichain
    {
        private Ichain next;

        public void SendRequest(NetworkModel request)
        {
            if (request.Success == false)
            {
                Console.WriteLine("send SSH failed . sending Ping");
                next.SendRequest(request);
            }
            else
            {
                Console.WriteLine("Send SSH success");
            }
        }

        public void SetNext(Ichain nextChain)
        {
            this.next = nextChain;
        }
    }
}
