namespace Specification.Domain
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieContext _movieContext;

        public MovieRepository(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public List<Movie> Search(bool? HasDvd)
        {
            return _movieContext.Movies.Where(c => !HasDvd.HasValue || ( HasDvd.Value && c.CreateDate <= DateTime.Now.AddMonths(-1))).ToList();
        }

        public List<Movie> Search(Specification<Movie> specification)
        {
            return _movieContext.Movies.Where(c => specification.IsSatisfiedBy(c)).ToList();
        }
    }
} 