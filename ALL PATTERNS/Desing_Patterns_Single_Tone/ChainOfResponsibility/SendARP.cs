using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Desing_Patterns.ChainOfResponsibility
{
    internal class SendARP : Ichain
    {
        private Ichain next;

        public void SendRequest(NetworkModel request)
        {
            if (request.Success == false)
            {
                Console.WriteLine("send ARP failed ");
                if (next != null)
                {
                    next.SendRequest(request);
                }
                else
                {
                    Console.WriteLine("network transmiision failed!!!! shuting down");
                }
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
