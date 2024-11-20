using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Interfaces
{
    public class Dog : IAnimal
    {
        //Declaration of properties
        public string Name { get; set; }
        //Constructor
        public Dog(string name)
        {
            Name = name;
        }

        //Method to make sound
        public void MakeSound()
        {
            Console.WriteLine("Dog barks woof!");
        }
    }
}
