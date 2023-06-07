using System;

namespace Method_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Maths maths = new Maths();
            Console.WriteLine("Hello, go ahead and enter a number so we may do a math on it!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            maths.first = num1;
            Console.WriteLine("Now enter another number! Or don't (just hit enter). It actually doesn't really matter!");
            string num2 = Console.ReadLine();
            if (num2 != "")
            {
                int finalNum2 = Convert.ToInt32(num2);
                maths.second = finalNum2;

                maths.final = Maths.Operation(num1, maths.second);
                Console.WriteLine("Okay, here is some maths I just performed");
                Console.WriteLine(num1 + " multiplied by " + finalNum2 + " is: " + maths.final);
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("I knew you were a gamblin' one");

                maths.final = Maths.Operation(num1);
                Console.WriteLine(num1 + " multiplied by 420 "  + " is: " + maths.final);
                Console.ReadLine();
            }
            
        }
    }
}
