using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsProject
{
    class Person
    {
        public string FirstName { get; set; } // two properties that get first name and set first name in main method

        public string LastName { get; set; }  // two properties that get last name and set last name in main method 

        public void SayName() // void method called SayName() that takes no parameters
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); //  writes the person's full name to the console in the format of: “Name: [full name]”.
        }

    }
}
