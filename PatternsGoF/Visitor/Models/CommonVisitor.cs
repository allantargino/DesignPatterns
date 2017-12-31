using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Interfaces;

namespace Visitor.Models
{
    class CommonVisitor : IVisitor<float>
    {
        public float VisitConstant(ConstantExpression<float> expression)
        {
            return expression.Value;
        }

        public float VisitSum(SumExpression<float> expression)
        {
            return expression.Left.Accept(this) + expression.Right.Accept(this);
        }
    }
}
