using Microsoft.EntityFrameworkCore;

namespace MovieApi.Models
{
  public class MovieApiContext : DbContext
  {
    public DbSet<Movie> Movies { get; set; }

    public MovieApiContext(DbContextOptions<MovieApiContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Movie>()
        .HasData(
          new Movie { MovieId = 1, Name = "Ready Player One", Genre = "SciFi", ReleaseDate = "2011" },
          new Movie { MovieId = 2, Name = "Land Before Time", Genre = "Family", ReleaseDate = "1988" },
          new Movie { MovieId = 3, Name = "Matilda", Genre = "Fantasy", ReleaseDate = "1996" },
          new Movie { MovieId = 4, Name = "Everything Everywhere All at Once", Genre  = "Sci-fi", ReleaseDate = "2022" },
          new Movie { MovieId = 5, Name = "I See You", Genre = "Suspense", ReleaseDate = "2019" }
        );
    }
  }
}