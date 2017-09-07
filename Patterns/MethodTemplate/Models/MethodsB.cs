using MethodTemplate.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MethodTemplate.Models
{
    class MethodsB:IMethods
    {
        public void Close()
        {
            Console.WriteLine("Closing B...");
        }

        public void Connect()
        {
            Console.WriteLine("Connecting B...");
        }

        public void Get()
        {
            Console.WriteLine("Getting B...");
        }
    }
}
