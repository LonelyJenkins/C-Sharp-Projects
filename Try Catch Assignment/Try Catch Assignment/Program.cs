using System;

namespace Try_Catch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 10, 30, 40, 68, 100, 500, 120 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("type in a number to divide all of those numbers by!");

            try
            {
                int divNum = Convert.ToInt32(Console.ReadLine());

                foreach (int num in numbers)
                {
                    Console.WriteLine(num / divNum);
                }

            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero you will actually end the world..");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally //this field will be run irregardless of if an exception is caught or not. Helpful if exceptions return user to other part of program/site
            {
                Console.WriteLine("Whoo! My head hurts");
                Console.ReadLine();
            }
        }
    }
}
