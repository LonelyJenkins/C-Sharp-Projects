using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //while loop
            Console.WriteLine("Guess a number, any number");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;

            while (!isGuessed)
            {
                switch (num)
                {
                    case 12:
                        Console.WriteLine("GREAT! You guessed correctly");
                        isGuessed = true;

                        //do while loop
                        int i = 0;
                        do
                        {
                            Console.WriteLine("the answer wasn't " + i + "!");
                            i++;
                        }
                        while (i != 12);
                        //end do while loop
                        break;

                    default:
                        Console.WriteLine("Ouch. You guessed wrong.");
                        Console.WriteLine("What's your next guess?");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }

            Console.ReadLine();
        }
    }
}
