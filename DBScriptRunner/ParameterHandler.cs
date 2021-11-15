using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DBScriptRunner
{
    public class ParameterHandler

    {
        string[] mainArgs;
        Hashtable ProcessedParams = null;
        public ParameterHandler(string[] Args)
        {
            mainArgs = Args;        
        }

        public Hashtable ProcessParameters()
        {
            ProcessedParams = new Hashtable();
            for (int i = 0; i != mainArgs.Length; ++i)
            {
                switch (mainArgs[i])
                {
                    case "-scriptfile": ProcessedParams.Add(Utility.Parameters.FILEPATH, mainArgs[++i]); break;
                    case "-servername": ProcessedParams.Add(Utility.Parameters.SERVERNAME, mainArgs[++i]); break;
                    case "-dbname": ProcessedParams.Add(Utility.Parameters.DBNAME, mainArgs[++i]); break;
                    case "-username": ProcessedParams.Add(Utility.Parameters.USERNAME, mainArgs[++i]); break;
                    case "-password": ProcessedParams.Add(Utility.Parameters.PASSWORD, mainArgs[++i]); break;
                }
            }
            return ProcessedParams;
        }
    }
}
