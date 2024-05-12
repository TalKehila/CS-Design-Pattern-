using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.ChainOfResponsibility
{
    public class NetworkModel
    {
        public string IP { get; set; }
        public bool Success { get; set; }

        public NetworkModel(string IP ,bool success)
        {
            this.IP = IP;
            this.Success = success;
        }
    }
}
