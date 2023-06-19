using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Assignment
{
    public class Employee<T> : Person, IQuittable
    {
        public List<T> Things;

        public override void SayName()
        {
            Console.WriteLine("Hello, " + firstName + " " + lastName);
        }

        public void Quit()
        {
            Console.WriteLine("That's it! I quit!!");
        }

        public void employeeData( string fname, string lname, int ident)
        {
            id = ident;
            firstName = fname;
            lastName = lname;
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

        public static bool operator ==(Employee<T> person1, Employee<T> person2)
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

        public static bool operator !=(Employee<T> person1, Employee<T> person2)
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
