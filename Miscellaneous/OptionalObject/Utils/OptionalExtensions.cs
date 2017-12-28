using System;
using System.Collections.Generic;
using System.Text;

namespace OptionalObject.Utils
{
    static class OptionalExtensions
    {
        public static void Do<T>(this Optional<T> optional, Action<T> action)
        {
            foreach (var value in optional)
                action(value);
        }
    }
}
