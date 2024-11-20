using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Events
{
    internal class PersonProgram
    {
      /*  static void Main(string[] args)
        {
            Person person = new Person("Dipesh",17);
           // person.Age = 17;

            // Subscribe to the AgeChanged event
            person.AgeChanged += Person_AgeChanged;

            // Change the age to trigger the event
            person.Age = 20; // This will trigger the event
        }*/

        // Event handler method
        private static void Person_AgeChanged(object sender, AgeChangedEventArgs e)
        {
            Console.WriteLine($"The age changed from {e.OldAge} to {e.NewAge}");
            if (e.NewAge > 18)
            {
                Console.WriteLine("Ready to be married!");
            }
        }
    }
}
