using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceProject
{
    class Program
    {
        static void Main(string[] args)
        {

            // Program begin
            Console.WriteLine("Car Insurance Approval Program");
            Console.WriteLine("\nTo get started, please hit the space key.\n");
            Console.ReadKey();


            // Prompt User for Various inputs such as integer and boolean
            Console.WriteLine("\nPlease enter your age.\n");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHave you ever had a DUI? Please enter \"true or false.\"\n");
            bool userDUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\nHow many speeding tickets do you have?\n");
            int userTickets = Convert.ToInt32(Console.ReadLine());


            // Display boolean result based on above user input.
            bool userResult = (userAge > 15 && userDUI != true && userTickets <= 3);
            Console.WriteLine("\nYour eligibilty for insurance will be determined by True = Yes or False = No\n");
            Console.WriteLine(userResult);
            
            // Program end
            Console.WriteLine("\nThank you for using our program. Press enter to quit. Drive safe!\n");
            Console.ReadLine();

        }
    }
}
