using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageShippingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program Start
            Console.WriteLine("\nWelcome user to Package Express! Please follow the instructions below to calculate your shipping quote.\n");

            // Prompt user input for questions regarding package dimensions, each with assigned variables
            Console.WriteLine("\nPlease enter the package weight:\n");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            // if statement check to determine program direction progress or cancellation from user input stored in created variable packageWeight
            if (packageWeight > 50)
            {
                Console.WriteLine("\nPackage too heavy to be shipped via Package Express. Have a good day.\n");
                Console.ReadLine();
                // Utilize Enviroment.Exit(0) to terminate program on user based on if statement input
                Environment.Exit(0);
            }

            Console.WriteLine("\nPlease enter the package width:\n");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease enter the package height:\n");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease enter the package length:\n");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            // if statement check to determine program direction progress or cancellation from user input stored in created variable totalDimensionCheck
            int totalDimensionCheck = packageWidth + packageHeight + packageLength;
            if (totalDimensionCheck > 50)
            {
                Console.WriteLine("\nPackage too big to be shipped via Package Express. Have a good day.\n");
                Console.ReadLine();
                // Utilize Enviroment.Exit(0) to terminate program on user based on if statement input
                Environment.Exit(0);
            }

            // final math calculations to determine user quote
            int finalDimensionTotal = packageHeight * packageWidth * packageLength;
            decimal total = finalDimensionTotal * packageWeight / 100;

            // format decimal total to display $ currency to user
            string formattedTotal = String.Format("{0:C}", total);

            // final total statement displayed to user, with program end
            Console.WriteLine("\nYour estimated total for shipping this package is:\n");
            Console.WriteLine(formattedTotal);
            Console.WriteLine("\nThank you for using our system, GoodBye...\n");

            // program end
            Console.ReadLine();

        }
    }
}
