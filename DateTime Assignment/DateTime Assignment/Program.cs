using System;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It is currently: " + DateTime.Now);
            Console.WriteLine("Please choose a number, any number between 1 and 24");
            int hours  = Convert.ToInt32(Console.ReadLine());
            DateTime futureTime = DateTime.Now.AddHours(hours);
            Console.WriteLine("In EXACTLY " + hours + " hours, it will be " + futureTime);
            Console.ReadLine();

        }
    }
}
