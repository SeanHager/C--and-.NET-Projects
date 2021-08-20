using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a number that you would like to see divided by a set number list.\n");
            Console.WriteLine("\nThe numbers in our list are 10, 20, 30, 40, 50, 100. Your input will be divided by these numbers. Lets begin!\n");
            Console.WriteLine("\nEnter your number.\n");
            //try catch block
            try
            {
                List<int> numbers = new List<int>() { 10, 20, 30, 40, 50, 100 };

                int userInput = Convert.ToInt32(Console.ReadLine());

                foreach (int num in numbers)
                {
                    Console.WriteLine(num / userInput); // divide user input by int in list 'numbers'
                }
            }
            //catch block with custom display message if user divides by zero
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("\nError! Please don't divide by zero");
            }
            //catch block with custom display message if user divides by a string
            catch (FormatException ex)
            {
                Console.WriteLine("\nError! Please enter in a valid whole number!");
            }
            finally
            {
                Console.WriteLine("\nProgram has emerged from the try/catch block and continued on with program execution");
                Console.ReadLine();
            }

         
        }
    }
}
