namespace Desing_Patterns.Adapter.DataProccesor
{
    internal class DataProccessor : IDataProccessor
    {
        
        public bool DataProcess()
        {
            Console.WriteLine(" Processed data");
            return true;
        }
        public void SendNetWorkRequest(string ip, string apiKey)
        {
            Console.WriteLine("send network request with  ip adress : " + ip);
        }
    }
}
