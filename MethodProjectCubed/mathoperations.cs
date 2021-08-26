using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodProjectCubed
{
    class mathoperations
    {
        public void MultiplyCubed(int num, int num2) //a "void" method does not require a return statement, takes in two integers as parameters 
                                                     //The void keyword in the C# language indicates that a method returns nothing.
        {
            int result = num * num * num;           //first parameter will be cubed

            Console.WriteLine(num2);                //second parameter will be displayed
        }
    }
}
