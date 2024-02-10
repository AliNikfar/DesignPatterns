using System.Linq.Expressions;

namespace Specification.Domain
{
    internal class AllSpec<T> : Specification<T>
    {
        public override Expression<Func<T, bool>> MyExpression()
        {
            return c => true;
        }
    }
} 