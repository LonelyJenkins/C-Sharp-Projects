using System;
using System.Collections.Generic;

namespace Console_App_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
             //announcing string array
             string[] names = { "John", "Eric", "Michael", "Robert", "Justin", "Seth" };
             Console.WriteLine("Type in the phrase ' is (insert adjective)'");
             string adj = Console.ReadLine();

             //looping through strings+concatenating user input with strings
             for (int i = 0; i < names.Length; i++)
             {
                 Console.WriteLine(names[i] + adj);
             }

             Console.ReadLine();


             //creating while loop that utilizes <
             int j = 0;
             int f = 0;
             int nameLimit = 3;
             while (j < names.Length)
             {
                 Console.WriteLine(names[j] + " LOVES MINECRAFT");
                 j++;

             }
             //creating while loop that utilizes <=
             while (f <= nameLimit)
             {
                 Console.WriteLine(names[f] + " is ALSO A CERTIFIED MINER");
                 f++;
             }

             Console.ReadLine();


             //announcing new list of strings
             List<string> movies = new List<string>();

             movies.Add("Jurassic Park");
             movies.Add("Alien vs Predator");
             movies.Add("Amityville Horror");
             movies.Add("The Last House On The Left");
             movies.Add("The Blair Witch Project");
             movies.Add("The Expendables");
             movies.Add("Forrest Gump");
             movies.Add("Beauty And The Beast");
             movies.Add("Land Before Time");
             movies.Add("Resident Evil");

             Console.WriteLine("Please type in a word to search in our *tiny* movie list");
             string search = Console.ReadLine();
             bool searchFound = false;

             for (int i = 0; i < movies.Count; i++)
             {
                 if (movies[i].Contains(search))
                 {
                     searchFound = true;
                     Console.WriteLine(movies[i]);
                     break;
                 }
             }

             if (!searchFound)
             {
                 Console.WriteLine("Not on our list! Try again!");
             }

             Console.ReadLine();


            List<string> games = new List<string>();
            games.Add("Doom");
            games.Add("Doom 2");
            games.Add("Doom 3");
            games.Add("Doom Eternal");
            games.Add("Legend Of Zelda");
            games.Add("Wolfenstein 3D");
            games.Add("Far Cry");
            games.Add("Call Of Duty");
            games.Add("Rainbow Six");
            games.Add("Quake");

            bool isRepeated = false;

            foreach (string game in games)
            {

                for (int i = 0; i < games.Count; i++)
                {
                    if (games[i].Contains(game) && !isRepeated)
                    {
                        isRepeated = true;
                        Console.WriteLine("The Games List contains repeats!");
                        break;
                    }

                }

                if (!isRepeated)
                {
                    Console.WriteLine("There are no repeated items in the games list!");
                }
            }

            Console.WriteLine("Please type in a word to search in our *tiny* game list");
            string gameSearch = Console.ReadLine();
            bool gameFound = false;

            for (int i = 0; i < games.Count; i++)
            {
                if (games[i].Contains(gameSearch))
                {
                    gameFound = true;
                    Console.WriteLine(games[i]);
                }
            }

            if (!gameFound)
            {
                Console.WriteLine("Not on our list! Try again!");
            }

            Console.ReadLine();
        }
    }
}
