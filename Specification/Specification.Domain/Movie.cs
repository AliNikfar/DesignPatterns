namespace Specification.Domain
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public AvailableAge availableAge { get; set; }


    }
} 