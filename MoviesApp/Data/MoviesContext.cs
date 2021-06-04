using Microsoft.EntityFrameworkCore;
using MoviesApp.Models;

namespace MoviesApp.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options) {}
        
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Actor> Actors { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            GenerateMovies(10, modelBuilder);
        }

        private void GenerateMovies(int amount, ModelBuilder modelBuilder)
        {
            for (var i = 1; i <= amount; i++)
            {
                CreateMovie(new Movie
                {
                    ID = i,
                    Name = Faker.CompanyFaker.Name(),
                    CoverURL = "https://i.pinimg.com/originals/c3/be/67/c3be67bf37cbd41fc762a3254e3ed6cd.jpg",
                    Rating = Faker.NumberFaker.Number(2, 10)
                }, modelBuilder);
            }
        }
        
        private void CreateMovie(Movie movie, ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(movie);
        }
    }
}