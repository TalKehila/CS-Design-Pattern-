using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.Proxy
{
    internal class SuperSecretDBProxy : ISuperSecretDB
    {
        private SuperSecretDB superSecretDatabase;
        private string databaseName;
        private string password;

        public SuperSecretDBProxy(string databaseName ,string password)
        {
            this.databaseName = databaseName;
            this.password = password;
            
        }
        public void DisplayDatabaseName()
        {
            if(password.Equals("password"))
            { 
                if(superSecretDatabase == null)
                {
                    superSecretDatabase = new SuperSecretDB(databaseName);
                }
                superSecretDatabase.DisplayDatabaseName();
            }
        }

    }
    
}
