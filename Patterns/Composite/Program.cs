using Composite.Models;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var dev1 = new Developer("John");
            var dev2 = new Developer("Tony");
            var man1 = new Manager("Jonny");
            var man2 = new Manager("Marie");
            man1.AddDirectEmployee(dev1);
            man1.AddDirectEmployee(dev2);
            man2.AddDirectEmployee(man1);

            man2.Work();

            Console.ReadLine();
        }
    }
}
