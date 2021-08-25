using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodProject
{
    class Program
    {
        static void Main(string[] args)
        {
            methodsoperation m = new methodsoperation(); // instantiate class methodsoperation

            Console.WriteLine("Please enter in your first number.");
            int userInput1 = Convert.ToInt32(Console.ReadLine());   //user enters number

            Console.WriteLine("What is your second number? This number is optional. Please type \"no\" if you would not like to enter a number."); //second number optional
            string userInput2 = Console.ReadLine();

            if (userInput2 == "no")  //if user types no, method used will return whatever number they entered first plus a standard programmed addition of 10 to first input
            {
                Console.WriteLine(m.Add(userInput1));
            }

            else
            {
                int userInputMod = Convert.ToInt32(userInput2); //create variable userInputMod to convert string to int. if user enters in number, it will be added to the first
                Console.WriteLine(m.Add(userInput1, userInputMod));
            }
            Console.ReadLine();
        }
    }
}
