using NullObject.Models;
using System;

namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Employee("John", 1000.0, new LowerPromotion());
            john = john.GetPromotion();

            var joe = new Employee("Joe", 2000.0, new NonePromotion());
            joe = joe.GetPromotion();

        }
    }
}
