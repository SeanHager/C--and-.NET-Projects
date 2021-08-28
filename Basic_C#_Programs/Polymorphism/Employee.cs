using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Employee : Person, IQuittable //class called Employee will inherit the Person class
    {
        string firstName;
        string lastName;

        public override void SayName() //Implement the SayName() method inside of the Employee class
        {
            // Console.WriteLine("Name: " + firstName + " " + lastName );
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine("This current student has quit the course."); // Inherit interface IQuittable and implement the Quit() method
        }

    }
}
