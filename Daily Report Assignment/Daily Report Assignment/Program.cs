using System;

namespace Daily_Report_Assignment
{
    class Program
    {
        static void Main()
        {
            //strings announced as variables for readability
            string school = "The Tech Academy";
            string report = "Student Daily Report";
            string nameQ = "What is your name?";
            string courseQ = "What course are you on?";
            string pageQ = "What page number?";
            string helpQ = "Do you need help with anything? Please answer 'true' or 'false'";
            string experienceQ = "Were there any positive experiences you'd like to share? Please give specifics!";
            string hoursQ = "How many hours did you study today?";

            Console.WriteLine(school);
            Console.WriteLine(report);

            Console.WriteLine(nameQ);
            string yourName = Console.ReadLine();
            Console.WriteLine("Well hello, " + yourName + "!!");

            Console.WriteLine(courseQ);
            string courseName = Console.ReadLine();

            Console.WriteLine(pageQ);
            string pageNum = Console.ReadLine();
            int pageNum2 = Convert.ToInt32(pageNum);

            Console.WriteLine(helpQ);
            string answer = Console.ReadLine();
            bool answer2 = Convert.ToBoolean(answer);

            Console.WriteLine(experienceQ);
            string response = Console.ReadLine();

            Console.WriteLine(hoursQ);
            string hoursWorked = Console.ReadLine();
            int hoursWorked2 = Convert.ToInt32(hoursWorked);

            Console.WriteLine("Thank you for your answers, " + yourName + "!! An instructor will respond to this shortly. Have a great day and good luck on the " + courseName + " course!");
            Console.ReadLine();


        }
    }
}
