using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification.Domain
{
    public class Program
    {
        public void Show(List<Movie> movies)
        {
            var hasDvd = new HasDvd();
            var isForChild = new IsForChild();
            var mySpec = hasDvd.And(isForChild);


            foreach (Movie movie in movies)
            {
                if (mySpec.IsSatisfiedBy(movie))
                Console.WriteLine($"{movie.Name} has DVD");
            }
        }
    }
}
