using System;

namespace Class_Submission_Assignment
{
    static class Program
    {
        static void Main(string[] args)
        {
            int newNum;

            MathOps mathOps = new MathOps();

            Console.WriteLine("Hello! Please enter a number so I may split it in half!");
            int num = Convert.ToInt32(Console.ReadLine());
            mathOps.Operation(num);
            Console.ReadLine();
            Console.WriteLine("Enter a new number so we can multiply it!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            mathOps.Operation(num, num1, out newNum);
            Console.WriteLine(newNum);
        }
    }
}
