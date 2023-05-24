using System;

namespace Boolean_Logic__Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string ageQ = Console.ReadLine();
            int age = Convert.ToInt32(ageQ);
            Console.WriteLine("Have you ever had a DUI?(Please write 'true' or 'false')");
            string duiQ = Console.ReadLine();
            bool DUI = Convert.ToBoolean(duiQ);
            Console.WriteLine("How many speeding tickets do you have?");
            string ticketQ = Console.ReadLine();
            int tickets = Convert.ToInt32(ticketQ);

            bool isQualified;
            if (age > 15 && !DUI && tickets <= 3)
            {
                isQualified = true;
            }

            else
            {
                isQualified = false;
            }

            Console.WriteLine("So, are you qualified?");
            Console.WriteLine(isQualified);
            Console.ReadLine();
        }
    }
}
