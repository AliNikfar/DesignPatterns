using Microsoft.EntityFrameworkCore;

namespace Specification.Domain
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
    }
} 