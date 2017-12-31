using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Models;

namespace Visitor.Interfaces
{
    interface IVisitor<T> where T:struct
    {
        T VisitConstant(ConstantExpression<T> expression);
        T VisitSum(SumExpression<T> expression);
    }
}
