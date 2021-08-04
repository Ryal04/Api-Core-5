using System;
using System.Collections.Generic;
using System.Linq;
using api.Models;
using api.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/movies")]
    public class MoviesController : ControllerBase
    {
        private IMovieInfoRepository _repository;
        private IMapper _mapper;

        public MoviesController(IMovieInfoRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public IActionResult GetMovies()
        {
            var movies = _repository.GetMovies();
            return Ok(_mapper.Map<IEnumerable<MovieDto>>(movies));
        }
        
        [HttpGet("{id}")]
        public IActionResult GetMovie(int id, bool includeCast)
        {
            var movie = _repository.GetMovie(id, includeCast);

            if (!_repository.MovieExists(id))
            {
                return NotFound();
            }

            return Ok(_mapper.Map<MovieDto>(movie));
        }

    }
}