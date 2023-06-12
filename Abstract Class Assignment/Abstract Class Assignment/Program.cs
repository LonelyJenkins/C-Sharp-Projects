using System;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool duplicateID = true;

            Person person = new Employee();
            Console.WriteLine("Enter your first name");
            person.firstName = Console.ReadLine();
            Console.WriteLine("Now enter your last name");
            person.lastName = Console.ReadLine();
            Console.WriteLine("Now enter your two digit ID number (DEFINITELY DO NOT CHOOSE '10'!!");
            person.id = Convert.ToInt32(Console.ReadLine());

            person.SayName();
            Console.ReadLine();

            Person person1 = new Employee();
            person1.id = 10;

            duplicateID = person == person1;

            if (duplicateID == true)
            {
                Console.WriteLine("ID MUST BE CHANGED");
                Console.ReadLine();
            }
            else if (duplicateID == false) 
            {
                Console.WriteLine("ID IS VALID");
                Console.ReadLine();
            }

            IQuittable quit = new Employee();
            quit.Quit();
            Console.ReadLine();

        }
    }
}
