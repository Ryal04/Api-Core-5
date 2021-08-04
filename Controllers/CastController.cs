using System;
using System.Linq;
using api.Models;
using api.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [ApiController]
    [Route("api/movies/{movieid}/casts")]
    public class CastController : ControllerBase
    {
        public ILogger<CastController> _logger;
        private IMailService _localMailService;
        private IMovieInfoRepository _repository;

        public CastController(ILogger<CastController> logger, IMailService localMailService, IMovieInfoRepository repository)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _localMailService = localMailService ?? throw new ArgumentNullException(nameof(logger));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }


        [HttpGet]
        public IActionResult GetCasts(int movieId)
        {
            
            if (!_repository.MovieExists(movieId))
            {
                return NotFound();
            }
            

                return Ok();
            
        }

        [HttpGet("{id}", Name = "GetCasts")]
        public IActionResult GetActionResult(int movieId, int id)
        {

            try
            {

                var movie = MovieDataStore.Current.Movies.FirstOrDefault(x => x.Id == movieId);

                if (movie == null)
                {
                    return NotFound();
                }

                var cast = movie.Casts.FirstOrDefault(x => x.Id == id);

                if (cast == null)
                {
                    _logger.LogInformation($"El Cast Con el {id} no fue encontrado");
                    return NotFound();
                }
                else
                {
                    return Ok(cast);
                }

            }
            catch (System.Exception ex)
            {
                _logger.LogCritical($"Error ocurrido en intento de buqueda del Cast con Id: {id} el cual no fue encontrado", ex);
                return StatusCode(500, "Disculpe Tuvimos un error <3");
            }
        }

        [HttpPost]
        public IActionResult CreateCast(int movieId, [FromBody] CasteForCreationDto casteForCreationDto)
        {
            var movie = MovieDataStore.Current.Movies.FirstOrDefault(x => x.Id == movieId);

            if (movie == null)
            {
                return BadRequest();
            }

            var maxCastId = MovieDataStore.Current.Movies.SelectMany(x => x.Casts).Max(p => p.Id);

            var newCast = new CastDto
            {
                Id = ++maxCastId,
                name = casteForCreationDto.name,
                Character = casteForCreationDto.Character
            };

            movie.Casts.Add(newCast);

            return CreatedAtRoute(
                nameof(GetCasts),
                new { movieId, id = newCast.Id },
                casteForCreationDto
            );
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCast(int movieId, int id, [FromBody] CastForUpdateDto castForUpdateDto)
        {
            var movie = MovieDataStore.Current.Movies.FirstOrDefault(x => x.Id == movieId);

            if (movie == null)
            {
                return NotFound();
            }

            var castFromStore = movie.Casts.FirstOrDefault(x => x.Id == id);
            if (castFromStore == null)
            {
                return NotFound();
            }

            castFromStore.name = castForUpdateDto.name;
            castFromStore.Character = castForUpdateDto.Character;

            return NoContent();

        }

        [HttpPatch("{id}")]
        public IActionResult PartialUpdateCast(int movieId, int id, [FromBody] JsonPatchDocument<CastForUpdateDto> patchDocument)
        {
            var movie = MovieDataStore.Current.Movies.FirstOrDefault(x => x.Id == movieId);

            if (movie == null)
            {
                return NotFound();
            }

            var castFromStore = movie.Casts.FirstOrDefault(x => x.Id == id);
            if (castFromStore == null)
            {
                return NotFound();
            }

            var castToPatch = new CastForUpdateDto()
            {
                name = castFromStore.name,
                Character = castFromStore.Character
            };

            patchDocument.ApplyTo(castToPatch, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (!TryValidateModel(castToPatch))
            {
                return BadRequest();
            }

            castFromStore.name = castToPatch.name;
            castFromStore.Character = castToPatch.Character;


            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCast(int movieId, int id)
        {

            var movie = MovieDataStore.Current.Movies.FirstOrDefault(x => x.Id == movieId);

            if (movie == null)
            {
                return NotFound();
            }

            var castFromStore = movie.Casts.FirstOrDefault(x => x.Id == id);
            if (castFromStore == null)
            {
                return NotFound();
            }

            _localMailService.Send("Recurso Eliminado", $"el recurso con id {id} fue eliminado");
            movie.Casts.Remove(castFromStore);

            return NoContent();
        }
    }
}
