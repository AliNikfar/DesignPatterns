using System.Linq.Expressions;

namespace Specification.Domain
{
    internal class AndSpec<T> : Specification<T>
    {
        private readonly Specification<T> _left;
        private readonly Specification<T> _right;
        public AndSpec (Specification<T> left , Specification<T> right)
        {
            _left = left;
            _right = right;
        }
        public override Expression<Func<T, bool>> MyExpression()
        {
            Expression<Func<T, bool>> leftExpression = _left.MyExpression();
            Expression<Func<T, bool>> rightExpression = _right.MyExpression();
            var param = leftExpression.Parameters[0];
            var paramExpr = Expression.Parameter(param.Type);
            BinaryExpression body = Expression.AndAlso(leftExpression.Body, rightExpression.Body);
            body = (BinaryExpression)new ParameterReplacer(paramExpr).Visit(body);
            var finalExpr = Expression.Lambda<Func<T, bool>>(body, paramExpr);
            return finalExpr;

        }
    }
} 