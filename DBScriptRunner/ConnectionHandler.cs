using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DBScriptRunner
{
    public static class ConnectionHandler
    {
        public static string ConnectionString(Hashtable Args)
        {
            string sqlConnectionString = "Data Source=" + Args[Utility.Parameters.SERVERNAME] + ";Initial Catalog=" + Args[Utility.Parameters.DBNAME] + ";uid=" + Args[Utility.Parameters.USERNAME] + ";pwd=" + Args[Utility.Parameters.PASSWORD] + ";Integrated Security=True";
            return sqlConnectionString;
           
        }
    }
}
