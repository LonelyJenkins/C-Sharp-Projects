using System;
using System.Collections.Generic;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //taking new variables
            Console.WriteLine("Enter an integer you wish for me to perform maths on!");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now enter a floating number for me to perform maths on!");
            float num1 = (float)Convert.ToDecimal(Console.ReadLine());

            Numbers numbers = new Numbers();
            numbers.intNum = num;
            numbers.floatingNum = num1;

            Console.WriteLine("Let's suquare your first number!");
            Multiply(numbers);
            Console.WriteLine(numbers.finalNum);
            Console.ReadLine();

            Console.WriteLine("Now let's multiply both your numbers together!");
            Multiply(numbers, numbers.floatingNum);
            Console.WriteLine(numbers.finalNum);
            Console.ReadLine();

            Console.WriteLine("Go ahead and type one more number for us to do maths on!");
            string newestNum = Console.ReadLine();
            Multiply(numbers, newestNum);
            Console.WriteLine("That number times the first number you put is: " + numbers.finalNum + "!!!");
            Console.ReadLine();

        }

        public static Numbers Multiply(Numbers numbers)
        {
            int numm = numbers.intNum;
            int final = numm * numm;
            numbers.finalNum = final;
            return numbers;
        }

        public static Numbers Multiply(Numbers number, float num)
        {
            float final = num * number.intNum;
            number.finalNum = final;
            return number;
        }

        public static Numbers Multiply(Numbers number, string num)
        {
            int newNum = Convert.ToInt32(num);
            int final = newNum * number.intNum;
            number.finalNum = final;
            return number;
        }
    }
}
