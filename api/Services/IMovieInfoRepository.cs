using System.Collections.Generic;
using System.Linq;
using api.Entities;

namespace api.Services
{
    public interface IMovieInfoRepository
    {
         IEnumerable<Movie> GetMovies();

         Movie GetMovie(int movieId);

         IEnumerable<Cast> GetCastsByMovie(int movieId);

         Cast GetCastByMovie(int movieId, int castId);
    }
}