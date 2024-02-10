using System.Linq.Expressions;

namespace Specification.Domain
{
    public abstract class Specification<T>
    {
        public static Specification<T> All()
        {
            return new AllSpec<T>();
        }
        public abstract Expression<Func<T, bool>> MyExpression();
        public bool IsSatisfiedBy(T input)
        {
            var predict = MyExpression().Compile();
            return predict(input);
        }
        public Specification<T> And(Specification<T> right)
        {
            return new AndSpec<T>(this, right);
        }

    }
} 