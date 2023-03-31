using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApi.Models;

namespace MovieApi.Controllers
{
  [Route("api/v{version:apiVersion}[controller]")]
  [ApiController]
  [ApiVersion("1.0")]
  public class MoviesController : ControllerBase
  {
    private readonly MovieApiContext _db;

    public MoviesController(MovieApiContext db)
    {
      _db = db;
    }

    // GET api/movies
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Movie>>> Get()
    {
      return await _db.Movies.ToListAsync();
    }


    // GET: api/Movies/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Movie>> GetMovie(int id)
    {
      Movie movie = await _db.Movies.FindAsync(id);

      if (movie == null)
      {
        return NotFound();
      }

      return movie;
    }

    // POST api/movies
    [HttpPost]
    public async Task<ActionResult<Movie>> Post([FromBody] Movie movie)
    {
      _db.Movies.Add(movie);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetMovie), new { id = movie.MovieId }, movie);
    }

        // PUT: api/Movies/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Movie movie)
    {
      if (id != movie.MovieId)
      {
        return BadRequest();
      }

      _db.Movies.Update(movie);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!MovieExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool MovieExists(int id)
    {
      return _db.Movies.Any(e => e.MovieId == id);
    }

    // DELETE: api/Movies/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMovie(int id)
    {
      Movie movie = await _db.Movies.FindAsync(id);
      if (movie == null)
      {
        return NotFound();
      }

      _db.Movies.Remove(movie);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}