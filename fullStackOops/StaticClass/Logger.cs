using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.StaticClass
{
    public static class Logger
    {
        public static void Log(string message)
        { 
            //write to a file, database, or external logging service
            System.Diagnostics.Debug.WriteLine(message);
        }
    }
}
