using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.PartialClassMethod
{
    internal partial class Employee
    {
        // Implementation of the partial method
        partial void DisplayDetails()
        {
            Console.WriteLine("Employee Id: " + this.EmpId);
            Console.WriteLine("Employee Name: " + this.EmpName);
        }
    }
}
