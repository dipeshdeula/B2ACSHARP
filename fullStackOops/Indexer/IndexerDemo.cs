using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Indexer
{
    internal class Sentence
    {
        //initialize the string array
        private string[] words = "My name is Dipesh".Split();

        // Indexer declaration
        public string this[int wordNum]
        {
            /*get
            {
                return words[wordNum];
            }*/

            get => words[wordNum];
            set => words[wordNum] = value;
            /*{
                words[wordNum] = value;
            }*/
        }
        /*public static void Main(string[] args)
        {
            // Create a new Sentence instance
            Sentence s = new Sentence();
            // Get the 1st word
            Console.WriteLine(s[0]);
            Console.WriteLine(s[1]);
            Console.WriteLine(s[2]);
            //set the 3rd word
            s[3] = "Ramesh"; 
            Console.WriteLine(s[3]);
        }*/
    }
}
