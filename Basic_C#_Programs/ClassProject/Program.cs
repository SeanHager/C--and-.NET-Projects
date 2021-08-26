using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            mathoperations m = new mathoperations();            // Instantiate method to call class

            Console.WriteLine("Please input a number.");        // User input
            int userInput = Convert.ToInt32(Console.ReadLine());// Convert input string to integer

            m.Divide(userInput);                                // Pass userInput to Divide() method

            Console.ReadLine();                                 // Allow console to stay open until user moves on
        }
    }
}
