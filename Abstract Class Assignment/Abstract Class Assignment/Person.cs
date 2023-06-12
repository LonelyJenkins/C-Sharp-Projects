using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Assignment
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public int id { get; set; }

        public abstract void SayName();

       
    }
}
