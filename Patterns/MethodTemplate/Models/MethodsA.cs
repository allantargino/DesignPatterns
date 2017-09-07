using MethodTemplate.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MethodTemplate.Models
{
    class MethodsA : IMethods
    {
        public void Close()
        {
            Console.WriteLine("Closing A...");
        }

        public void Connect()
        {
            Console.WriteLine("Connecting A...");
        }

        public void Get()
        {
            Console.WriteLine("Getting A...");
        }
    }
}
