using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Assignment
{
    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Hello, " + firstName + " " + lastName);
        }
    }
}
