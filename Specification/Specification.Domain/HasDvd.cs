using System.Linq.Expressions;

namespace Specification.Domain
{
    public class HasDvd : Specification<Movie>
    {
        public override Expression<Func<Movie, bool>> MyExpression()
        {
            return c => c.CreateDate <= DateTime.Now.AddMonths(-6);
        }
    }
    public class IsForChild : Specification<Movie>
    {
        public override Expression<Func<Movie, bool>> MyExpression()
        {
            return c => c.availableAge == AvailableAge.Children || c.availableAge == AvailableAge.Kids;
        }
    }
} 