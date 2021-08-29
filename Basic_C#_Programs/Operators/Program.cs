using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //overload the “==” operator so it checks if two employee objects are equal by comparing their id property
            Employee e = new Employee();
            Employee b = new Employee();

            int eId = 45; //use the newly overloaded == operator to compare two employee objects by their id
            int eId2 = 45; // change values to reflect if values are or are not equal

            bool same = false; // set boolean variable same to false 

            e.Id = eId;  // set e and b values in order to compare Id values
            b.Id = eId2; 

            same = e == b; // determine if e and b are equal to each other
            Console.WriteLine(same);
            Console.ReadLine();


        }
    }
}
