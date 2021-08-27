using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person               // Created abstract class called Person that contains two properties
    {
        
         public string firstName { get; set; } // set string properties for firstName 
         public string lastName { get; set; }  // set string properties for lastName.

         public virtual void SayName()         // virtual methods allow subclasses of the type to override the method
         {
             Console.WriteLine("Name: " + firstName + " " + lastName);
         }

        
    }
}
