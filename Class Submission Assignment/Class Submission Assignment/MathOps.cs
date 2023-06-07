using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Submission_Assignment
{
    class MathOps
    {
        public void Operation(int num)
        {
            int final = num / 2;
            Console.WriteLine(final);
        }

        public void Operation(int num, int num1, out int newNum)
        {
            int final = num * num1;
            newNum = final;
        }
    }
}
