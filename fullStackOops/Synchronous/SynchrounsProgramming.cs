using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Synchronous
{
    internal class SynchrounsProgramming
    {

        //Method to read and process the file synchronously
        public static void ReandAndProcessFile(string filePath)
        {
            try
            {
                //Read the file content
                string content = File.ReadAllText(filePath);
                Console.WriteLine("File content read successfully.");

                //Process the file content
                ProcessContent(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred:{ex.Message}");
            }
        }

        //Method to process the file content
        public static void ProcessContent(string content)
        {
            //simulate some processing
            Console.WriteLine("Processing content...");
            string[] lines = content.Split('\n');
            foreach (var line in lines)
            {
                Console.WriteLine($"Processed line: {line.Trim()}");
            }

            Console.WriteLine("Content processed successfully");
        }
       /* static void Main(string[] args)
        {
            //Define the file path
            string filePath = "data.txt";

            //write some sample data to the file
            File.WriteAllText(filePath, "Hello World!\n,Welcome to synchrous Programming in C#\nI want to be synchronized!");

            //Read and process the file synchrounously
            ReandAndProcessFile(filePath);
        }*/
    }
}
