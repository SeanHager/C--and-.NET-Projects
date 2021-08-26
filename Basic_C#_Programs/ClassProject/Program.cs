using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            mathoperations m = new mathoperations();            // Instantiate method to call class

            Console.WriteLine("Please input a number.");        // User input
            int userInput = Convert.ToInt32(Console.ReadLine());// Convert input string to integer

            m.Divide(userInput);                                // Pass userInput to Divide() method

            // Method Overloading

            Console.WriteLine("Add two numbers: \n" + mathoperations.addDisplay(5, 5));
            Console.WriteLine("Add three numbers: \n" + mathoperations.addDisplay(5, 5, 5));
            Console.WriteLine("Add four numbers: \n" + mathoperations.addDisplay(5, 5, 5, 5));


            Console.ReadLine();                                 // Allow console to stay open until user moves on
        }
    }
}
