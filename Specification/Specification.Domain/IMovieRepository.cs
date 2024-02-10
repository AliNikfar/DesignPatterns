namespace Specification.Domain
{
    public interface IMovieRepository
    {
        List<Movie> Search(bool? HasDvd);
        List<Movie> Search(Specification<Movie> specification);
    }
} 