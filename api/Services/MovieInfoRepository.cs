using System;
using System.Collections.Generic;
using api.Context;
using api.Entities;

namespace api.Services
{
    public class MovieInfoRepository : IMovieInfoRepository
    {
        private MovieInfoContext _context;

        public MovieInfoRepository(MovieInfoContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public Cast GetCastByMovie(int movieId, int castId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Cast> GetCastsByMovie(int movieId)
        {
            throw new System.NotImplementedException();
        }

        public Movie GetMovie(int movieId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Movie> GetMovies()
        {
            throw new System.NotImplementedException();
        }
    }
}