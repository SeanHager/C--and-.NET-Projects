using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChains
{
    public class gasBudget
    {
        public gasBudget() : this(200)
        {

        }

        public gasBudget(int budg)
        {
            Console.WriteLine("Our monthly gas budget is: $" + budg);
            Console.ReadLine();
        }
    }
}
