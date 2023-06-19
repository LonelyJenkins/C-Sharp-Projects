using System;
using System.Linq;
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
 
            //LAMBDA ASSIGNMENT SECTION

            List<Employee<string>> employees = new List<Employee<string>>();

            Employee<string> employee1 = new Employee<string>();
            Employee<string> employee2 = new Employee<string>();
            Employee<string> employee3 = new Employee<string>();
            Employee<string> employee4 = new Employee<string>();
            Employee<string> employee5 = new Employee<string>();
            Employee<string> employee6 = new Employee<string>();
            Employee<string> employee7 = new Employee<string>();
            Employee<string> employee8 = new Employee<string>();
            Employee<string> employee9 = new Employee<string>();
            Employee<string> employee10 = new Employee<string>();

            employee1.employeeData("John", "Cena", 1);
            employees.Add(employee1);
            employee2.employeeData("John", "Jacob", 2);
            employees.Add(employee2);
            employee3.employeeData("Carl", "Grimes", 3);
            employees.Add(employee3);
            employee4.employeeData("Daryl", "Dixon", 4);
            employees.Add(employee4);
            employee5.employeeData("Carol", "Peletier", 5);
            employees.Add(employee5);
            employee6.employeeData("Shane", "Walsh", 6);
            employees.Add(employee6);
            employee7.employeeData("Glenn", "Rhee", 7);
            employees.Add(employee7);
            employee8.employeeData("Dale", "Horvath", 8);
            employees.Add(employee8);
            employee9.employeeData("John", "MacTavish", 9);
            employees.Add(employee9);
            employee10.employeeData("Rick", "Grimes", 10);
            employees.Add(employee10);

            /* NON LAMBDA
             List<Employee<string>> johns = new List<Employee<string>>();

            foreach (Employee<string> employee in employees)
            {
                if (employee.firstName == "John")
                {
                    johns.Add(employee);
                }
            }
            */

            //LAMBDA
            List<Employee<string>> johns = employees.Where(x => x.firstName == "John").ToList();

            foreach (Employee<string> john in johns)
            {
                Console.WriteLine("Wow here's another guy named john!");
                Console.WriteLine(john.firstName + " "  + john.lastName);
            }

            Console.ReadLine();

            List<Employee<string>> overFive = employees.Where(x => x.id > 5).ToList();

            foreach (Employee<string> over in overFive)
            {
                Console.WriteLine("Looks like " + over.firstName + " has an id number of: " + over.id);
            }

            Console.ReadLine();


        }
    }
}
