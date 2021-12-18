using System;
using System.Collections.Generic;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var casinoRoyale = new Movie("Casino Royale", "Eon Productions", "PG13");
            var glass = new Movie("Glass", "Buena Vista International", "PG13");
            var spiderMan = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");

            var movies = new List<Movie>
            {
                casinoRoyale,
                glass,
                spiderMan
            };

            var filtered = GetPg(movies.ToArray());
            foreach (var movie in filtered)
            {
                Console.WriteLine($"{movie}");
                Console.WriteLine($"{movie.Display()}");
            }
        }

        public static Movie[] GetPg(Movie[] movies)
        {
            var filtered = new List<Movie>();

            foreach (var movie in movies)
            {
                if (movie.Rating == "PG")
                {
                    filtered.Add(movie);
                }
            }

            return filtered.ToArray();
        }
    }
}
