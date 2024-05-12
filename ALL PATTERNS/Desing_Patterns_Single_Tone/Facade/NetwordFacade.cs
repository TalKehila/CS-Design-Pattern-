using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.Facade
{
    internal class NetwordFacade
    {
        private Packet packet;
        private Socket socket;
        private Transmission transmission;

        public NetwordFacade(string ip ,string protocol)
        {
            this.packet = new Packet(ip);
            this.socket = new Socket(protocol); 
            this.transmission = new Transmission(protocol);
        }

        public void BuildNetworkLayer()
        {
            packet.PacketBuilt();
            socket.BuiltSocket();
        }
        public void SendPacketOverNetwork()
        {
            BuildNetworkLayer();
            transmission.SendTransmiision();
        }
    }
}
