using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Interfaces
{
    internal class DemoInterface : IMyInterface, IMyInterface1
    {
        public void MyMethod()
        {
            Console.WriteLine("This is MyMethod from DemoInterface");
        }

       /* public static void Main(string[] args)
        { 

        }*/
    }
}
