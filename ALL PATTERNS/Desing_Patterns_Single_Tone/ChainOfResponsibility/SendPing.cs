using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Desing_Patterns.ChainOfResponsibility
{
    internal class SendPing : Ichain
    {
        private Ichain next;
        public void SendRequest(NetworkModel request)
        {
            if (request.Success == false)
            {
                Console.WriteLine("send Pin failed . sending APR");
                next.SendRequest(request);
            }
            else
            {
                Console.WriteLine("Send Pin success");
            }
        }
        public void SetNext(Ichain nextChain)
        {
           this.next = nextChain;
        }
    }
}
