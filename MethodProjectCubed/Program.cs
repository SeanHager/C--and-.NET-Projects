using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodProjectCubed
{
    class Program
    {
        static void Main(string[] args)
        {

            mathoperations m = new mathoperations();    //create object to instantiate the class and call on methods

            m.MultiplyCubed(2, 6);                      //math will be performed on first number, second number will be displayed
            
            m.MultiplyCubed(num: 3, num2: 20);          //calling both parameters

            Console.ReadLine();


        }
    }
}
