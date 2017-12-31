using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Interfaces
{
    interface IExpression<T> where T : struct
    {
        T Accept(IVisitor<T> visitor);
    }
}
