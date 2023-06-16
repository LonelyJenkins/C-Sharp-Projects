using System;

namespace Parsing_Enums
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main()
        {
            Console.WriteLine("Please enter what day of the week it is! (Be sure it is capitalized!)");
            try
            {
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine());
                Console.WriteLine("Okay, I guess today is " + day);
                Console.ReadLine();
            }

            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week, silly.");
                Console.ReadLine();
            }

        }

    }
}
