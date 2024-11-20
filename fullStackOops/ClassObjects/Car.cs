using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.ClassObjects
{
    public class Car
    {
        //public fields
        public string? Make;
        public string? Model;

        //public method
        public void DisplayInfo()
        {
            Console.WriteLine("Make: {0}", Make);
            Console.WriteLine("Model: {0}", Model);
        }

    }
}
