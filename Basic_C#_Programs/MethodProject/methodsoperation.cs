using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodProject
{
    class methodsoperation
    {
        public int Add(int num1, int num2 = 10) //two parameters, one optional that adds 10 regardless to user input 1
        {
            int result = num1 + num2;
            return result;                      //returns integer
        }

    }
}
