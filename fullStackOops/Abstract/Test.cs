using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Abstract
{
    abstract class Test
    {
        //abstract method-> no body
        public abstract void Display1();

        //Non-abstract method-> with body
        public void Display2()
        {
            Console.WriteLine("Non-abstract method");
        }
    }
}
