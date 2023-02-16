using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.ADO.DBManager.AdoStudio
{
    internal class ServerConnection
    {
        public static string connectionString;

        public static void GetConnectionStringByName(string name)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                connectionString = settings.ConnectionString;
        }
    }
}
