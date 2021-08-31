using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    class Employee // Employee class created
    {
        public string FirstName { get; set; } //Get and Set properties for FirstName, LastName, and Id in Main program Lists

        public string LastName { get; set; } 

        public int Id { get; set; } 

        public Employee(string firstName, string lastName, int Id) //Created constructor to house Employee function variables
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = Id;
        }
    }
}
