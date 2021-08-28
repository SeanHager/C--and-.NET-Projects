using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
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

            IQuittable i = new Employee();             //Polymorphism utilized to create an object type of IQuittable
            i.Quit();                                  //Calls Quit() method
            Console.ReadLine();
        }
    }
    
}
