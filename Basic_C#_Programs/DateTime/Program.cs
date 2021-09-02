using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeLog
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now; // Print out current time and date to the console
            Console.WriteLine("The current date and time is: {0}", now);
            Console.ReadLine();

            Console.WriteLine("Please enter in a number to see what the time will be in hours from your input."); // Ask user for input number
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The exact date and time that will be {0} hours from now is: {1}",userInput, DateTime.Now.AddHours(userInput)); // Print to console exact time it will be in x hours, with x = userInput
            Console.ReadLine();
        }
    }
}
