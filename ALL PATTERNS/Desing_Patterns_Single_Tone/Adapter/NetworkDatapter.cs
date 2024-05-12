using Desing_Patterns.Adapter.DataProccesor;
using Desing_Patterns.Adapter.Network_client_;

namespace Desing_Patterns.Adapter
{
    //this class know to talk to data proccessor and data pro know to to talk network client
    internal class NetworkDatapter : INetworkClient
    {

        private readonly IDataProccessor _dataProcessor; // to hold insstance of data processor
        public NetworkDatapter(IDataProccessor dataProcessor)
        {
            _dataProcessor = dataProcessor;
        }
        public void SendRequest(string ipAddress) // implement the method from INetworkClient interface
        {
            var apiKey = "df432r2f23rffds";
            _dataProcessor.SendNetWorkRequest(ipAddress, apiKey);
        }
    }
}
