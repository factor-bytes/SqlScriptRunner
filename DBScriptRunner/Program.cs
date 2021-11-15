using System;
using System.Collections;

namespace DBScriptRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable Args = new Hashtable();
            ParameterHandler paramHandler = new ParameterHandler(args);
            Args = paramHandler.ProcessParameters();
            SQLGenerator.GenerateDB(Args);
        }
    }
}
