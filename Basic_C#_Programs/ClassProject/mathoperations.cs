using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
    class mathoperations // static class
    {
        public void Divide(int number) // void method created that outputs integer, this method will divide that data passed to it by 2
        {
            int result = number / 2;
            Console.WriteLine(result);
        }

        public void outputParameterOverload(out int number, out int number2) // output parameters with overload method
        {
            number = 10;
            number2 = 15;
        }
    }
}
