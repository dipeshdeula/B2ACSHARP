using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Destructor
{
    public class MyClass
    {
        private string resource;

        //constructor
        public MyClass()
        {
            resource = "Students";
            Console.WriteLine("Resource acquired : "+resource);
        }

        //Destructor
        ~MyClass()
        {
            Console.WriteLine("Resource destroyed");
            //code to release the resources or perform clean up activities
        }

        //Method to display some operations
        public void DoWork()
        { 
            Console.WriteLine("Performing some operations");
        
        }
        

    }
}
