using System;

namespace Method_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOps mathOps = new MathOps();

            Console.WriteLine("Enter a number that I may use for maths!");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number!!");
            int number2 = Convert.ToInt32(Console.ReadLine());

            mathOps.Operation(num1: number, num2: number2);
        }
    }
}
