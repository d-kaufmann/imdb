using Microsoft.EntityFrameworkCore;
using Model.Entity;

namespace Model.Configuration {
    public class MovieDbContext : DbContext{

        public DbSet<Movie> Movie { get; set; }
        
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options) {
            
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<Movie>()
                .HasIndex(m => m.Name)
                .IsUnique();
            
            //base.OnModelCreating(builder);
        }
        
    }
}