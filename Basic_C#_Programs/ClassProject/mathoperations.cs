using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
    public class mathoperations 
    {
        public void Divide(int num) // void method created that outputs integer, this method will divide that data passed to it by 2
        {
            int result = num / 2;
            Console.WriteLine(result);
        }

        // Method overloading
        //Two or more than two methods having the same name but different parameters is what we call method overloading in C#.
        //Method overloading in C# can be performed by changing the number of arguments and the data type of the arguments.

        public static int addDisplay(int one, int two)
        {
            return one + two;
        }

        public static int addDisplay(int one, int two, int three)
        {
            return one + two + three;
        }

        public static int addDisplay(int one, int two, int three, int four)
        {
            return one + two + three + four;
        }


    }
}
