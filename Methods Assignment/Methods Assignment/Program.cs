using System;
using System.Collections.Generic;

namespace Methods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, you must type a number that I will then perform maths on...");
            int num = Convert.ToInt32(Console.ReadLine());
            int multNum = MathOps.Multiplication(num);
            int divNum = MathOps.split(num);
            int cubedNum = MathOps.cube(num);
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("Here is your number now squared: " + multNum);
            Console.ReadLine();
            Console.WriteLine("Here is your number now split in half: " + divNum);
            Console.ReadLine();
            Console.WriteLine("NOW Here is your number cubed: " + cubedNum);
            Console.ReadLine();
        }
    }
    
}
