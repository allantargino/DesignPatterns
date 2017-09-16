using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"This person's name is {Name} and he/she is {Age} years";
        }
    }
}
