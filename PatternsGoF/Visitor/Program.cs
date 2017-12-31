using System;
using Visitor.Models;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var e = SumExpression<float>.CreateSum(
                ConstantExpression<float>.CreateConstant(5.0f),
                SumExpression<float>.CreateSum(
                    ConstantExpression<float>.CreateConstant(11.0f),
                    ConstantExpression<float>.CreateConstant(18.0f)
                    )
                );

            var result = e.Accept(new CommonVisitor());

            Console.WriteLine($"Hello World! Result: {result}");
            Console.ReadLine();
        }
    }
}
