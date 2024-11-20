using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Constructors
{
    public class DemoConstructor
    {
        public int value { get; set; }

        // Explict Parameter Constructor
        public DemoConstructor()
        {
            value = 10; //initialize with a default value
            
            Console.WriteLine("Pubilc Constructor called");
        }

    }

    public class DemoConstrcutor2
    {
        public int value2 { get; set; }

        // Explict Parameterized Constructor
        public DemoConstrcutor2(int value)
        {
            value2 = value; //initialize with a default value
            
            Console.WriteLine($"Parameter Pubilc Constructor called {value2}");
        }

        public DemoConstrcutor2()
        {
        }

        public void CreateDemoConstructor()
        { 
            //create an instance o f DemoConstructor using the parameterless constructor
            DemoConstructor demoConstructor = new DemoConstructor();
            DemoConstrcutor2 demoConstrcutor2 = new DemoConstrcutor2(20);
            Console.WriteLine(demoConstructor.value);
            Console.WriteLine(demoConstrcutor2.value2);

        }

        

        
        
    }
}
