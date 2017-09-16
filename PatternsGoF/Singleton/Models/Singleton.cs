using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Models
{
    public class Singleton<T> where T : class
    {
        private static T _type;

        public static void Init(T instance)
        {
            _type = instance;
        }

        public static T Instance()
        {
            if (_type == null)
                throw new ArgumentNullException(nameof(T));
            else
                return _type;
        }
    }
}
