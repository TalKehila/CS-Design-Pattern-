using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.Proxy
{
    internal class SuperSecretDB :ISuperSecretDB // we dont people will have access to this class 
    {
        private string _databaseName;
        public SuperSecretDB(string databaseName)
        {
            _databaseName = databaseName;
        }
        public void DisplayDatabaseName()//we dont want people will see this without Authentication
        {
            Console.WriteLine("display data base name: "  + _databaseName);
        } 
    }
}
