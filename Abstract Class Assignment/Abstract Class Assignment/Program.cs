using System;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Employee();
            Console.WriteLine("Enter your first name");
            person.firstName = Console.ReadLine();
            Console.WriteLine("Now enter your last name");
            person.lastName = Console.ReadLine();

            person.SayName();
            Console.ReadLine();
        }
    }
}
