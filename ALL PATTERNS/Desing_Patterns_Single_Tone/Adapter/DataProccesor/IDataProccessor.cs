namespace Desing_Patterns.Adapter.DataProccesor
{
    internal interface IDataProccessor
    {

        bool DataProcess();

        void SendNetWorkRequest(string ip, string apiKey);

    }
}
