using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/movies")]
    public class MovieController : ControllerBase {
       
       
       public IActionResult GetMovies(){
        return Ok(MovieDataStore.Current.Movies);
       }
       
       [HttpGet ("{id}")]
       public IActionResult GetMovie(int id){
          var movie = MovieDataStore.Current.Movies.FirstOrDefault(x => x.Id == id);
          if(movie == null){
              return NotFound();
          }else{
              return Ok(movie);
          }
       }
    }
}