using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChains
{
    class electricBudget : gasBudget //chain two constructors together by inheriting from another class
    {
        public electricBudget() // constructor
        {
            Console.WriteLine("A reminder that you also have an electric bill due.");
            Console.ReadLine();
        }
    }
}
