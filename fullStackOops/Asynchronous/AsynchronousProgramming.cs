using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace fullStackOops.Asynchronous
{
    internal class AsynchronousProgramming
    {
        /*static async Task Main(string[] args)
        {
            // Define the file path
            string filePath = "data.txt";

            // Write some sample data to the file (if it doesn't exist)
            if (!File.Exists(filePath))
            {
                await File.WriteAllTextAsync(filePath, "Hello, World!\nWelcome to asynchronous programming in C#.");
            }

            // Read and process the file asynchronously
            await ReadAndProcessFileAsync(filePath);
        }*/

        // Method to read and process the file asynchronously
        public static async Task ReadAndProcessFileAsync(string filePath)
        {
            try
            {
                // Read the file content asynchronously
                string content = await File.ReadAllTextAsync(filePath);
                Console.WriteLine("File content read successfully.");

                // Process the file content asynchronously
                await ProcessContentAsync(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        // Method to process the file content asynchronously
        public static async Task ProcessContentAsync(string content)
        {
            // Simulate some processing
            Console.WriteLine("Processing content...");
            string[] lines = content.Split('\n');
            foreach (var line in lines)
            {
                // Simulate asynchronous processing
                await Task.Delay(500); // Simulate a delay for processing each line
                Console.WriteLine($"Processed line: {line.Trim()}");
            }
            Console.WriteLine("Content processed successfully.");
        }
    }
}
