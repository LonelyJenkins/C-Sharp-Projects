using System;
using System.Collections.Generic;

namespace Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array of strings
            string[] nameArray = { "Thanos", "Vaas Montenegro", "Darth Vader", "Solomon Grundy", "Nosferatu" };
            Console.WriteLine("Type in a number from 0 to 4 to find out who you're gonna watch a movie with tonight!");
            string nameChoice = Console.ReadLine();
            int name = Convert.ToInt32(nameChoice);

            if (name < 0 || name > 4)
            {
                wrongAnswer();
            }
            else
            {
                Console.WriteLine("Tonight you are going to watch a movie with" + nameArray[name] + " and you're gonna like it!");
                Console.ReadLine();
            }

            //Array of integers
            int[] numArray = { 2, 5, 6, 7, 10, 9 };
            Console.WriteLine("Type in a number from 0 to 5 to find out how many movies you should watch this week!");
            string movieCount = Console.ReadLine();
            int movies = Convert.ToInt32(movieCount);

            if(movies < 0 || movies > 5)
            {
                wrongAnswer();
            }

            else
            {
                Console.WriteLine("Strap in, because you're in for a serious " + numArray[movies] + " movie binge this week!");
                Console.ReadLine();
            }





            //List of strings
            List<string> movieList = new List<string>();
            movieList.Add("Jurassic Park");
            movieList.Add("28 Days Later");
            movieList.Add("The Terminator");
            movieList.Add("King Kong");
            movieList.Add("Godzilla");

            Console.WriteLine("Type in a number from 0 to 4 to find out what movie to watch tonight!");
            string movieName = Console.ReadLine();
            int movie = Convert.ToInt32(movieName);
            if (movie < 0 || movie > 4)
            {
                wrongAnswer();
            }
            else
            {
                Console.WriteLine("Tonight you are going to watch " + movieList[movie] + " and you're gonna like it!");
                Console.ReadLine();
            }
        }

        static void wrongAnswer()
        {
            Console.WriteLine("Sorry, you didn't follow my simple instructions! Guess you missed out on that one...");
        }
    }
}
