using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Interfaces
{
    public class Robot : IMovabel, IReadable
    {
        public void Move()
        {
            Console.WriteLine("Robot moves!");
        }

        public void Read()
        {
            Console.WriteLine("Robot reads!");
        }
    }
   
}
