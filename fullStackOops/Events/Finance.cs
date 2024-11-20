using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Events
{
     class Finance
    {
        private readonly EmployeeSeparator employeeSeparator;
        public Finance (EmployeeSeparator employeeSeparated)
        
        { 
            this.employeeSeparator = employeeSeparated;
            //subscribe to the event
            employeeSeparator.EmployeeSeparated += EmployeeSeparatedEventHandler;
        }

        /* public void EmployeeSeparatedEventHandler()
         {
             Console.WriteLine("Finance department: employee separation process related to finance");
         }*/

        /*public void EmployeeSeparatedEventHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Finance department: employee separation process related to finance");
        }*/

        //for paramter
        public void EmployeeSeparatedEventHandler(object sender, EmployeeEventArgs e)
        {
            Console.WriteLine("Finance department : employee separation process related to finance" + e.Name);
        }
    }
}
