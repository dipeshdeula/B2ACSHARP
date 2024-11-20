using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace fullStackOops.Annonymous_Types
{
    
public class AnnonymousTypes
    {
        // Method to demonstrate anonymous types
        public void DisplayDetails()
        {
            // Anonymous Type
            var Details = new
            {
                FirstName = "Dipesh",
                LastName = "Deula",
                Age = 21,

                // It also accepts nested anonymous types
                Address = new
                {
                    City = "Hetauda",
                    StreetCity = "Gardai",
                    WardNo = 4
                },

                // It also accepts arrays
                Projects = new[] {
                    new { ProjectName = "Ecommerce", ProjectDuration = "40hrs" },
                    new { ProjectName = "Admin Portal", ProjectDuration = "25hrs" },
                    new { ProjectName = "Accounting", ProjectDuration = "30hrs" }
                }
            };

            // Display the details
            Console.WriteLine($"Name: {Details.FirstName} {Details.LastName}");
            Console.WriteLine($"Age: {Details.Age}");
            Console.WriteLine($"Address: {Details.Address.City}, {Details.Address.StreetCity}, Ward No: {Details.Address.WardNo}");
            Console.WriteLine("Projects:");
            foreach (var project in Details.Projects)
            {
                Console.WriteLine($"- {project.ProjectName} ({project.ProjectDuration})");
            }
        }

       /* public static void Main(string[] args)
        {
            AnnonymousTypes obj = new AnnonymousTypes();
            obj.DisplayDetails();
        }*/
    }
}
