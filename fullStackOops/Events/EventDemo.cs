using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Events
{
    class EmployeeEventArgs: EventArgs
    { 
        public int EmpId { get; set; }
        public string Name { get; set; }
    }

    class EmployeeSeparator
    {
        //custom event args
        //signature of the event handler
        // public delegate void EmployeeSeparatedEventHandler();
        //event
        //public event EmployeeSeparatedEventHandler EmployeeSeparated;


        //no parmater built in event handling
        // public event EventHandler EmployeeSeparated;


        // parameterized built in event handling
        public event EventHandler<EmployeeEventArgs> EmployeeSeparated;


        //publish the event
        public void Separate()
        {
            /*
                        if(EmployeeSeparated != null)
                        {
                            EmployeeSeparated(this,EventArgs.Empty);
                        }*/

            //for parameter
            EmployeeEventArgs employeeEventArgs = new EmployeeEventArgs
            {
                EmpId = 123,
                Name = "Dipesh"
            };

            if (EmployeeSeparated != null)
            {
                EmployeeSeparated(this, employeeEventArgs);

            }
        }
    }

}
