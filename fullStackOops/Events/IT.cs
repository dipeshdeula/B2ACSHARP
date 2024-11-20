using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Events
{
     class IT
    {
        private readonly EmployeeSeparator employeeSeparator;
        public IT(EmployeeSeparator employeeSeparated)

        {
            this.employeeSeparator = employeeSeparated;
            //subscribe to the event
            employeeSeparator.EmployeeSeparated += EmployeeSeparatedEventHandler;
        }

      /*  public void EmployeeSeparatedEventHandler()
        {
            Console.WriteLine("IT department: employee separation process related to IT");
        }*/

      /*  public void EmployeeSeparatedEventHandler(object sender,EventArgs e)
        {
            Console.WriteLine("IT department: employee separation process related to IT");
        }*/

        //for parameter
        public void EmployeeSeparatedEventHandler(object sender, EmployeeEventArgs e)
        {
            Console.WriteLine("IT department: employee separation process related to IT"+e.Name);
        }


    }
}
