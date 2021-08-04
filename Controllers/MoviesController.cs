using System;
using System.Collections.Generic;
using System.Linq;
using api.Models;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/movies")]
    public class MoviesController : ControllerBase
    {
        private IMovieInfoRepository _repository;

        public MoviesController(IMovieInfoRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public IActionResult GetMovies()
        {
            var movies = _repository.GetMovies();
            var results = new List<MovieDto>();

            foreach (var movieEntity in movies)
            {
                results.Add(
                    new MovieDto
                    {
                        Id = movieEntity.Id,
                        Name = movieEntity.Name,
                        Desc = movieEntity.Desc
                    }
                );

            }

            return Ok(results);
        }
        [HttpGet("{id}")]
        public IActionResult GetMovie(int id, bool includeCast)
        {
            var movie = _repository.GetMovie(id, includeCast);

            if (movie == null)
            {
                return NotFound();
            }

            var result = new MovieDto
            {
                Id = movie.Id,
                Name = movie.Name,
                Desc = movie.Desc
            };

            return Ok(result);
        }

    }
}