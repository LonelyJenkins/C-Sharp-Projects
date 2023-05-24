using System;

namespace Math_and_Comparison_Operators
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string p1Rate = Console.ReadLine();
            int p1R = Convert.ToInt32(p1Rate);
            Console.WriteLine("Hours worked per week?");
            string p1Hours = Console.ReadLine();
            int p1H = Convert.ToInt32(p1Hours);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string p2Rate = Console.ReadLine();
            int p2R = Convert.ToInt32(p2Rate);
            Console.WriteLine("Hours worked per week?");
            string p2Hours = Console.ReadLine();
            int p2H = Convert.ToInt32(p2Hours);

            int p1AnnualSal = (p1R * p1H) * 52;
            int p2AnnualSal = (p2R * p2H) * 52;
            bool salary;
            if (p1AnnualSal > p2AnnualSal)
            {
                salary = true;
            }
            else
            {
                salary = false;
            }


            Console.WriteLine("Annual salary of person 1: $" + p1AnnualSal);
            Console.WriteLine("Annual salary of person 2: $" + p2AnnualSal);

            Console.WriteLine("Does person 1 make more money than person 2?");
            Console.WriteLine(salary);
            Console.ReadLine();


        }
    }
}
