using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class mathoperations //created class
    {
        public int Add(int num1, int num2 = 10) //two parameters, one optional that adds 10 regardless to user input 1
        {
            int result = num1 + num2;
            return result;                      //returns integer
        }

        public int mathOp(int num)                   //method mathOp()
        {
            int result = num + num;                  //takes integer and does addition 
            return result;                           //returns answer as integer 

        }
        public int mathOp(double dec)                //method mathOp()
        {
            int result = Convert.ToInt32(dec - dec); //takes decimal and does subtraction
            return result;                           //returns answer as integer
        }

        public int mathOp(string strNum)            //method mathOp()
        {
            int num = Convert.ToInt32(strNum);      //takes string and converts to int
            int result = num * num;                 //does multiplication
            return result;                          //returns answer as integer
        }
    }
}
