using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Models
{
    public sealed class SingletonLazy<TInstance> where TInstance : class, new()
    {
        private static TInstance _instance;

        private SingletonLazy() { }

        public static TInstance Instance {
            get
            {
                if (_instance == null)
                    _instance = new TInstance();
                return _instance;
            }

        }
    }
}
