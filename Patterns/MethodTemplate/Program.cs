using MethodTemplate.Models;
using System;

namespace MethodTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            new Template<MethodsA>(new MethodsA()).Perform();
            new Template<MethodsB>(new MethodsB()).Perform();

            Console.ReadLine();
        }
    }
}
