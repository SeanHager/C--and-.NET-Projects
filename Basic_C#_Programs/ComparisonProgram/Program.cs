using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program begin
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("\nTo get started, please hit the space key.\n");
            Console.ReadKey();



            // Prompt Person 1 and Person 2 input for hourly rate and hours worked.
            Console.WriteLine("\nPlease enter in Person 1 hourly rate.\n");
            int hourlyRatePersonOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease enter in Person 1 hours worked in week.\n");
            int hoursWorkedPersonOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease enter in Person 2 hourly rate.\n");
            int hourlyRatePersonTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease enter in Person 2 hours worked.\n");
            int hoursWorkedPersonTwo = Convert.ToInt32(Console.ReadLine());


            // Display current yearly salary based off of 52 week work year, based off of user previous input for Person 1 and 2.
            Console.WriteLine("\nAnnual Salary of Person 1: Based on 52 week year.\n");
            int totalSalaryPersonOne = hourlyRatePersonOne * hoursWorkedPersonOne * 52;
            Console.WriteLine(totalSalaryPersonOne);

            Console.WriteLine("\nAnnual Salary of Person 2: Based on 52 week year.\n");
            int totalSalaryPersonTwo = hourlyRatePersonTwo * hoursWorkedPersonTwo * 52;
            Console.WriteLine(totalSalaryPersonTwo);

            // Compare total salary of Person 1 and 2 and boolean determine if Person 1 is > 2
            Console.WriteLine("\nDoes Person 1 make more money than Person 2?\n");
            bool incomeComparison = totalSalaryPersonOne > totalSalaryPersonTwo;
            Console.WriteLine(incomeComparison);

            // Program end
            Console.WriteLine("\nThank you for using our program. Press enter to quit.\n");
            Console.ReadLine();
        }
    }
}
