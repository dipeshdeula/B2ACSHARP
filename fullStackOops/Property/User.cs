using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Property
{
    internal class User
    {
        private string name;

        //property create for read only
        private string companyName;
        private int age;

        //constructor
        public User()
        {
            companyName = "Deula Tech";  
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string CompanyName
        {
            get { return companyName; }
        }

        public int Age
        {
            get { return age; }
            set {
                if (value < 19)
                { 
                
                Console.WriteLine("You are not eligible to work in this company");
                }
                else
                {
                    age = value;
                }
            }
        }

        /*public static void Main(string[] args)
        {
            User user = new User();
            user.Name = "Dipesh Deula";
            user.Age = 21;

            Console.WriteLine("Name: "+user.Name);
            Console.WriteLine("Company name: "+user.CompanyName);
            Console.WriteLine("Age: "+user.age);

        
        }*/
    }
}
