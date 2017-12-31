using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Interfaces;

namespace Visitor.Models
{
    class ConstantExpression<T> : IExpression<T> where T : struct
    {
        public T Value { get; }

        private ConstantExpression(T value)
        {
            Value = value;
        }

        public static ConstantExpression<T> CreateConstant(T value) => new ConstantExpression<T>(value);

        public T Accept(IVisitor<T> visitor) => visitor.VisitConstant(this);
    }
}
