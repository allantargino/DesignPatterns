using Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Models
{
    class Developer : IEmployee
    {
        public string Name { get; }

        public Developer(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            Name = name;
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is working!");
        }
    }
}
