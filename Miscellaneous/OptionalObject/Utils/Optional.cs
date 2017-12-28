using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OptionalObject.Utils
{
    class Optional<T> : IEnumerable<T>
    {
        private IEnumerable<T> _optional { get; }

        private Optional(IEnumerable<T> optional)
        {
            _optional = optional;
        }

        public static Optional<T> Some(T value) => new Optional<T>(new[] { value });

        public static Optional<T> None() => new Optional<T>(new T[0]);


        public IEnumerator<T> GetEnumerator() => _optional.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
