using System;
using System.Collections.Generic;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool duplicateID = true;

            Employee<string> person = new Employee<string>();
            person.Things = new List<string>();
            person.Things.Add("Cats");
            person.Things.Add("Dogs");
            person.Things.Add("Lizards");
            person.Things.Add("Fish");
            person.Things.Add("Capybaras");
            person.Things.Add("Emus");
            person.Things.Add("Bison");
            person.Things.Add("Tyranosaurus Rex");

            Console.WriteLine("Enter your first name");
            person.firstName = Console.ReadLine();
            Console.WriteLine("Now enter your last name");
            person.lastName = Console.ReadLine();
            Console.WriteLine("Now enter your two digit ID number (DEFINITELY DO NOT CHOOSE '10'!!");
            person.id = Convert.ToInt32(Console.ReadLine());

            person.SayName();
            Console.ReadLine();
            Console.WriteLine("Did you know that the following animals are pretty cool?");
            foreach (string thing in person.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();

            Employee<int> person1 = new Employee<int>();
            person1.id = 10;
            person1.Things = new List<int>();
            person1.Things.Add(10);
            person1.Things.Add(person.id);
            person1.Things.Add(420);
            Console.WriteLine("Between myself, you, and my friend, these are our ID numbers: ");
            foreach (int thing in person1.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();

            duplicateID = person.id == person1.id;

            if (duplicateID == true)
            {
                Console.WriteLine("YOUR ID MUST BE CHANGED");
                Console.ReadLine();
            }
            else if (duplicateID == false) 
            {
                Console.WriteLine("YOUR ID IS VALID");
                Console.ReadLine();
            }

            IQuittable quit = new Employee<int>();
            quit.Quit();
            Console.ReadLine();

        }
    }
}
