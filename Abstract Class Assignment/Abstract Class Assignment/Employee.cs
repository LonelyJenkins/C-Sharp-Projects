using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Assignment
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Hello, " + firstName + " " + lastName);
        }

        public void Quit()
        {
            Console.WriteLine("That's it! I quit!!");
        }
    }
}
