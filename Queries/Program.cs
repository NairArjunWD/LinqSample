﻿using System;
using System.Collections.Generic;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie>
            {
                new Movie { Title = "The Dark Knight", Rating = 8.9f, Year = 20},
                new Movie { Title = "The King's Speech", Rating = 8.9f, Year = 20},
                new Movie { Title = "Casablanca", Rating = 8.9f, Year = 20},
                new Movie { Title = "Star Wars V", Rating = 8.9f, Year = 20}
            };
        }
    }
}
