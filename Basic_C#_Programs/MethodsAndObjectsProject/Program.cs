using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee n = new Employee(); // instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student”
            Console.ReadLine();
            n.FirstName = "Sample";
            n.LastName = "Student";
            n.SayName(); // Call the superclass method SayName() on the Employee object.

            Console.ReadLine();
        }
    }
}
