using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Events
{
    // The publisher model
  /*  internal class EventExample
    {*/
        // Declare Delegate
      /*  public delegate void OddNumberEventHandler();
        public delegate void EvenNumberEventHandler();*/

        // Declare Event
       /* public event OddNumberEventHandler event_OddNumber;
        public event EvenNumberEventHandler event_EvenNumber;*/

      /*  public void Addition()
        {
            Console.WriteLine("Enter the values of Event Delegates:");
            Console.WriteLine("<----------------------------------->");
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 + num2;

            Console.WriteLine(result);

            if (result % 2 != 0)
            {
                // Raise event if result is an odd number
                 event_OddNumber?.Invoke();    
            }
            else
            {
                event_EvenNumber?.Invoke();
            }
        }*/

       /* static void Main()
        {
            EventExample eventExample = new EventExample();

            // Subscribe to the event
            eventExample.event_OddNumber += () => Console.WriteLine("The result is an odd number.");
            eventExample.event_EvenNumber += () => Console.WriteLine("The result is an even number.");

            eventExample.Addition();
        }*/
  /*  }*/
}
