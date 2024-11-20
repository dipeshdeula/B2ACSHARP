using fullStackOops.PartialClassMethod;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.PartialClassMethod
{
    internal partial class Employee
    {
        public int EmpId;
        public string? EmpName;

        public Employee(int empId, string empName)
        {
            EmpId = empId;
            EmpName = empName;
        }
        // Declaration of the partial method
        partial void DisplayDetails();



        /*public static void Main(string[] args)
        {
            Employee emp = new Employee(1, "Dipesh");
            emp.DisplayDetails();
        }*/
    }
}