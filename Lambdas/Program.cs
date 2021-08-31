using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>(); //list of at 10 employees. Each employee should have a first and last name, as well as an Id. At least two employees should have the first name “Joe”.
            employees.Add(new Employee("Sean", "Hager", 1));
            employees.Add(new Employee("Joe", "Goh", 2));
            employees.Add(new Employee("Shaman", "King", 3));
            employees.Add(new Employee("Taco", "Bell", 4));
            employees.Add(new Employee("Em", "Inem", 5));
            employees.Add(new Employee("Savage", "Wun", 6));
            employees.Add(new Employee("Joe", "Lost", 7));
            employees.Add(new Employee("Pine", "Apple", 8));
            employees.Add(new Employee("William", "Raynor", 9));
            employees.Add(new Employee("Sara", "Kerrigan", 1000));


            List<Employee> joeInList = new List<Employee>(); //list that contains number of Joes in above list

            foreach (Employee joe in employees) //foreach loop, that creates a new list of all employees with the first name “Joe”.
            {
                if (joe.FirstName.Equals ("Joe"))
                {
                    joeInList.Add(joe);
                }
            }

            List<Employee> newJoe = employees.Where(x => x.FirstName == "Joe").ToList(); //lambda expression that creates a new list of all employees with the first name “Joe”.

            List<Employee> newList = employees.Where(x => x.Id >= 5).ToList(); //lambda expression, that makes a list of all employees with an Id number greater than 5.

            Console.WriteLine("There are: " + joeInList.Count + " " + "Joe's in this list."); //display number of Joes in list to console
            Console.WriteLine("There are: " + newList.Count + " " + "users with an Id value greater than 5.");//displays number of users with ids greater than the number 5
            Console.ReadLine();//keeps console open to close


        }
    }
}
