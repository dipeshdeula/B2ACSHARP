using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Enum
{
    //Enum is a user-defined data type that has fixed set of related values
    enum WeekDays
    { 
        Monday, // by default it has value 0
        Tuesday=10, // 1
        Wednesday, //2
        Thursday,  //3
        Friday,   //4
        Saturday, //5
        Sunday  //6

    }
    internal class EnumDemo
    {
        public void Display()
        {
            Console.WriteLine(WeekDays.Monday);
            int day = (int)WeekDays.Monday;
            Console.WriteLine(WeekDays.Monday + ":" + day);

            int day2 = (int)WeekDays.Wednesday;
            Console.WriteLine(WeekDays.Wednesday+ ":" + day2);  

            int day3 = (int)WeekDays.Thursday;
            Console.WriteLine(WeekDays.Thursday+ ":" + day3);

            int day4 = (int)WeekDays.Friday;
            Console.WriteLine(WeekDays.Friday + ":" + day4);

            int day5 = (int)WeekDays.Saturday;
            Console.WriteLine(WeekDays.Saturday+ ":" + day5);

        }

       /* public static void Main(string[] args)
        { 
            EnumDemo e = new EnumDemo();
            e.Display();
        }*/
    }
}
