using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();               //Instantiate Employee class
            e.firstName = "Sample";                    //Instantied Employee Class has properties assigned to e
            e.lastName = "Student"; 
            e.SayName();                               //Call the SayName() method on the object
            Console.ReadLine();
        }
    }
}
