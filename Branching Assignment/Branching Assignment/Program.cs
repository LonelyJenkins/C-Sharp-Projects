using System;

namespace Branching_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express! Please follow the instructions below!");
            Console.WriteLine("Please input the package weight");
            string weight = Console.ReadLine();
            int packWeight = Convert.ToInt32(weight);

            if (packWeight > 50)
            {
                Console.WriteLine("Woah there, bud. That's too heavy for us... Bye!");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Please enter package width");
                string width = Console.ReadLine();
                int packWidth = Convert.ToInt32(width);

                Console.WriteLine("Please enter package height");
                string height = Console.ReadLine();
                int packHeight = Convert.ToInt32(height);

                Console.WriteLine("Please enter package length");
                string length = Console.ReadLine();
                int packLength = Convert.ToInt32(length);

                int totalCost = ((packHeight * packLength * packWidth) * packWeight) / 100;

                Console.WriteLine("Your estimated total for shipping this package is :$" + totalCost);
                Console.WriteLine("Thank you for choosing Package Express!");
                Console.ReadLine();
            }
        }
    }
}
