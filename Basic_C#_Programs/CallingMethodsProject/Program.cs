using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            mathoperation m = new mathoperation(); //created object to call methods in mathoperation class
            Console.WriteLine("Please enter a number to do a simple formula on itself.");
            int userInput = Convert.ToInt32(Console.ReadLine()); //user input

            int answer1 = m.Add(userInput); //calling method Add
            int answer2 = m.Subtract(userInput); //calling method Subtract
            int answer3 = m.Multiply(userInput); //caling method Multiply

            Console.WriteLine("This is your input + " + answer1);
            Console.WriteLine("This is your input - " + answer2);
            Console.WriteLine("This is your input * " + answer3);

            Console.ReadLine();
        }
    }
}
