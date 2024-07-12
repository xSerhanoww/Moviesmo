using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace movie_catalog_beta.Data
{
    public class MoviesDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<MovieActors> movieactors { get; set; }
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           var connectionString  = "server=localhost;user=root;password=;database=movie_catalog";
           var serverVersion = new MySqlServerVersion(new Version(10, 4, 27));
           optionsBuilder.UseMySql(connectionString, serverVersion);
        }

    }
    public class Movie
    {
        [Key]   
        public int MovieId { get; set; }
        
        public string Title { get; set; }

        public string Description { get; set; }

        [ForeignKey("DirectorId")]
        public int DirectorId { get; set; }

        [ForeignKey("CountryId")]
        public int CountryId { get; set; }

        [ForeignKey("GenreId")]
        public int GenreId { get; set; }

        public int Length { get; set; }



    }
    public class Actor
    {
        [Key]
        public int ActorId { get; set; } 

        public string Name { get; set; }
    }
    public class Director
    {
        [Key]
        public int DirectorId { get; set; }

        public string Name { get; set; }
    }
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        public string Name { get; set; }

    }
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        public string Name { get; set; }
    }
    public class MovieActors
    {
        [Key]
        public int MovieId { get; set; }

        [ForeignKey("ActorId")]
        public int ActorId { get; set; }
    }
    
}
