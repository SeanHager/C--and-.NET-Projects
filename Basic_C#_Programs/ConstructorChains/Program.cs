using System;


namespace ConstructorChains
{
    class Program
    {
        static void Main(string[] args)
        {
            const int yearlySalary = 45000; // constant variable
            var electricBudget = 5000; // //create variable with keyword var (the data type of a var variable will be determined when assigning values to variables)

            gasBudget g = new gasBudget(); // will also print out chain constructor
            electricBudget e = new electricBudget();

            Console.ReadLine();
        }
    }
}
