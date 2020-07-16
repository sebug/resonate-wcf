using System;
using System.Collections.Generic;
using Resonate.Services.Contracts;
using Resonate.Services.Entities;
using System.Linq;

namespace Resonate.Services
{
    public class SeenMovieService : ISeenMovieService
    {
        private static List<SeenMovie> SeenMovies { get; set; } = new List<SeenMovie>();

        public SeenMovie Add(SeenMovie movie)
        {
            var existing = SeenMovies.FirstOrDefault(m => m.Name == movie.Name);
            if (existing != null)
            {
                return existing;
            }
            SeenMovies.Add(movie);
            return movie;
        }

        public List<SeenMovie> GetAll()
        {
            return SeenMovies;
        }
    }
}