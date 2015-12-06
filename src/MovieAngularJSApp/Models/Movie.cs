using Microsoft.Data.Entity;

namespace MovieAngularJSApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
    }

    public class MoviesAppContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; } 
    }
}
