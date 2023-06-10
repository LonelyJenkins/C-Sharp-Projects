using System;

namespace Methods_And_Objects_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee();
            person.firstName = "Sample";
            person.lastName = "Student";

            person.SayName();
            Console.ReadLine();
        }
    }
}
