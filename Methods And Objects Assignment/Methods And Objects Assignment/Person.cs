using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_And_Objects_Assignment
{
    public class Person
    {
        public string firstName { get; set; }

        public string lastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
