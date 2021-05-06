using Model.Configuration;
using Model.Entity;

namespace Domain.Repository {
    public class MovieRepository : ARepository<Movie>, IMovieRepository {
        
        public MovieRepository(MovieDbContext movieDbContext) : base(movieDbContext) {
        }
        
    }
}