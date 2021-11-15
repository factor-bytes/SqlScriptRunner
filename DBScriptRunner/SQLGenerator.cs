using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;


namespace DBScriptRunner
{
    public static class SQLGenerator
    {
        
        public static void GenerateDB(Hashtable Args)
        {
            string sqlConnectionString = ConnectionHandler.ConnectionString(Args);
            FileInfo file = new FileInfo(Args[Utility.Parameters.FILEPATH].ToString());
            string script = file.OpenText().ReadToEnd();
            SqlConnection conn = new SqlConnection(sqlConnectionString);
            ServerConnection serverConn = new ServerConnection(conn);
            Server server = new Server(serverConn);
            server.ConnectionContext.ExecuteNonQuery(script);
            conn.Close();
        }

    }
}
