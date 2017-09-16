using Singleton.Models;
using System;
using System.Collections.Generic;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person()
            {
                Name = "Allan"
            };
            Singleton<Person>.Init(person);

            var p1 = Singleton<Person>.Instance();
            var p2 = Singleton<Person>.Instance();

            if (p1.Equals(p2))
                Console.WriteLine("Person Equal");
            else
                Console.WriteLine("Person Not Equal");


            Singleton<List<int>>.Init(new List<int>() { 1, 2, 3 });
            var l1 = Singleton<List<int>>.Instance();
            var l2 = Singleton<List<int>>.Instance();

            l1.Add(4);
            l2.Add(5);
            l1.Add(6);

            foreach (int num in l2)
                Console.WriteLine(num);

            Console.ReadLine();
        }
    }
}
