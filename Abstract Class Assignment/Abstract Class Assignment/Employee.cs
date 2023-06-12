using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Assignment
{
    public class Employee : Person, IQuittable
    {

        public override void SayName()
        {
            Console.WriteLine("Hello, " + firstName + " " + lastName);
        }

        public void Quit()
        {
            Console.WriteLine("That's it! I quit!!");
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static bool operator ==(Employee person1, Employee person2)
        {
            if (person1.id == person2.id)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static bool operator !=(Employee person1, Employee person2)
        {
            if (person1.id == person2.id)
            {
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}
