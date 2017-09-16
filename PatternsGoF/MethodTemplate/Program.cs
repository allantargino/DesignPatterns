using MethodTemplate.Models;
using System;

namespace MethodTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            new MethodsA().Perform();
            Console.WriteLine();
            new MethodsB().Perform();
            Console.ReadLine();
        }
    }
}
