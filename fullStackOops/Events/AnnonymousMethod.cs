using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Events
{
    public delegate void PrintMessage(string message);

    internal class AnnonymousMethod
    {
        public static void InvokeMethod()
        {
            PrintMessage printMessage = delegate (string message)
            {
                Console.WriteLine("Message:" + message);
            };

            printMessage("Hello world");

        }

        //main method
       /* static void Main(string[] args)
        {
            InvokeMethod();
        }*/
    }
}
