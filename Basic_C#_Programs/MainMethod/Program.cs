using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            mathoperations m = new mathoperations();    //create object to instantiate the class and call on methods

            Console.WriteLine("Please enter in your first number.");
            int userInput1 = Convert.ToInt32(Console.ReadLine());   //user enters number

            Console.WriteLine("What is your second number? This number is optional. To bypass enter in no"); //second number optional
            string userInput2 = Console.ReadLine();

            if (userInput2 == "no")  //if user types no, method used will return whatever number they entered first + 10
            {
                Console.WriteLine(m.Add(userInput1));
            }

            else
            {
                int userInputMod = Convert.ToInt32(userInput2); //create variable userInpuitMod to convert string to int. if user enters in number, it will be added to the first
                Console.WriteLine(m.Add(userInput1, userInputMod));
            }

            Console.ReadLine();             
            int answer = m.mathOp(20);                  //addition method
            Console.WriteLine(answer);

            int answer2 = m.mathOp(2.2);                //decimal and subtraction method
            Console.WriteLine(answer2);

            int answer3 = m.mathOp("20");               //string and multiplication method
            Console.WriteLine(answer3);
            Console.ReadLine();

        }

    }
}
