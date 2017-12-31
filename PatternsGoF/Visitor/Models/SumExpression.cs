using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Interfaces;

namespace Visitor.Models
{
    class SumExpression<T> : IExpression<T> where T:struct
    {
        public IExpression<T> Left { get; }
        public IExpression<T> Right { get; }

        private SumExpression(IExpression<T> left, IExpression<T> right)
        {
            Left = left;
            Right = right;
        }

        public static SumExpression<T> CreateSum(IExpression<T> left, IExpression<T> right) => new SumExpression<T>(left, right);

        public T Accept(IVisitor<T> visitor) => visitor.VisitSum(this);
    }
}
