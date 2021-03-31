using System;
using System.Collections.Generic;

namespace Lab4._2Movies
{
    class Movie
    {
        public string title;
        public string category;

        public Movie(string _title, string _category)
        {
            category = _category;
            title = _title;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie("Godzilla Vs. Kong", "Scifi"));
            movies.Add(new Movie("Alien", "Scifi"));
            movies.Add(new Movie("Bladerunner 2049", "Scifi"));
            movies.Add(new Movie("The Joker", "Drama"));
            movies.Add(new Movie("One Night In Miami...", "Drama"));
            movies.Add(new Movie("Antebellum", "Horror"));
            movies.Add(new Movie("The Grudge", "Horror"));
            movies.Add(new Movie("Countdown", "Horror"));
            movies.Add(new Movie("Incredibles", "Animated"));
            movies.Add(new Movie("Shrek", "Animated"));

            string userWantsToContinue;

            Console.WriteLine("Welcome to the Movie List Application!\n");

            Console.WriteLine("There are a total of 10 movies in this list");

            do
            {
                Console.Write("What category are you interested in?: ");

                string userCategory = Console.ReadLine();

                while (userCategory.ToLower() != "scifi" && userCategory.ToLower() != "drama" && userCategory.ToLower() != "horror" && userCategory.ToLower() != "animated")
                {
                    Console.Write("Invalid category! Please enter \"Scifi\", \"Drama\", \"Horror\", or \"Animated\": ");
                    userCategory = Console.ReadLine();
                }

                foreach (var movie in movies)
                {
                    if (string.Equals(userCategory, movie.category, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"{movie.title}");
                    }
                }

                Console.WriteLine("Continue? (y/n)");
                userWantsToContinue = Console.ReadLine().ToLower();

                while (userWantsToContinue != "y" && userWantsToContinue != "n")
                {
                    Console.WriteLine("Invalid entry! Please enter \"y\" or \"n\"");
                    userWantsToContinue = Console.ReadLine().ToLower();
                }
                
            } while (userWantsToContinue == "y");
        }
    }
}
