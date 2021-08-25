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
