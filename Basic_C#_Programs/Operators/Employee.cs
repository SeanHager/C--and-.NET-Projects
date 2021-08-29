using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Employee
    {
        public int Id { get; set; } //property called Id and have it be of data type int


        public static bool operator ==(Employee employee1, Employee employee2)  //comparing two objects w/ == operator 
        {
            return employee1.Id == employee2.Id;

            bool same = false; //default

            if (employee1.Id == employee2.Id) //overloading operator compares Employee objects by their ID properties
            {
                same = true; //return true if same
            }

            return same;
        }

        public static bool operator !=(Employee employee1, Employee employee2) //comparing two objects w/ != operator, needed when utilizing operator == overload
        {

            return employee1.Id == employee2.Id;

            bool same = true; //default

            if (employee1.Id != employee2.Id) //overloading operator compares Employee objects by their ID properties
            {
                same = false;
            }

            return same;
        }


    }
}
