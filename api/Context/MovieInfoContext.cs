using api.Entities;
using Microsoft.EntityFrameworkCore;

namespace api.Context
{
    public class MovieInfoContext : DbContext
    {
        public DbSet<Movie> Movies{get; set;}

        public DbSet<Cast> Casts{get; set;}

        public MovieInfoContext(DbContextOptions<MovieInfoContext> options): base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
              .HasData(
                new Movie{
                    Id = 1, 
                    Name = "Marbella Vice",
                    Desc = "Serie De gta Rolplay, ooc: muy buena"
                },
                new Movie{
                    Id = 2, 
                    Name = "TortillaLand",
                    Desc = "Serie de Minecract creada por Auron"
                },
                new Movie{
                    Id = 3, 
                    Name = "14Days",
                    Desc = "Seria de el juego Day Z con duracion de 14 Dias"
                }
            );

            modelBuilder.Entity<Cast>()
              .HasData(
                new Cast{
                    Id = 1, 
                    name = "Elisa Waves",
                    Character = "Iris Marquez",
                    MovieId = 1
                },
                new Cast{
                    Id = 2, 
                    name = "Karchez",
                    Character = "Greco Rodrigues",
                    MovieId = 1 
                },
                new Cast{
                    Id = 3, 
                    name = "Carola",
                    Character = "Fedor",
                    MovieId = 1
                },
                new Cast{
                    Id = 4, 
                    name = "carola",
                    Character = "carola",
                    MovieId = 2
                },
                new Cast{
                    Id = 5, 
                    name = "auron",
                    Character = "toni gambino",
                    MovieId = 2
                },
                new Cast{
                    Id = 6, 
                    name = "Elisa Waves",
                    Character = "elisa",
                    MovieId = 3
                },
                new Cast{
                    Id = 6, 
                    name = "Ronnie 6",
                    Character = "Ronnie",
                    MovieId = 3
                }

            );

            base.OnModelCreating(modelBuilder);
        }

    }
}