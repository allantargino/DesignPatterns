using MethodTemplate.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MethodTemplate.Models
{
    class MethodsA : Template
    {
        public override void Get()
        {
            Console.WriteLine("Getting A...");
        }
    }
}
