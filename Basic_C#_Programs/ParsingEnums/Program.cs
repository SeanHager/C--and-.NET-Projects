using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter in the day of the week."); // Prompt user input and assign input value to string
                string userInput = Console.ReadLine();
                Days day = (Days)Enum.Parse(typeof(Days), userInput); // parse enum to assign the value to a variable of enum data type created above
                Console.WriteLine("You have entered in: " + day);
                Console.ReadLine();
            }
            catch (Exception ex) // create custom catch statement thrown at user if they do not enter in correct day
            {
                Console.WriteLine("Please enter in an actual day of the week..");
                Console.ReadLine();
            }
        }
    }
}
