using System;
using OptionalObject.Utils;

namespace OptionalObject
{
    class Program
    {
        static Optional<string> name = Optional<string>.None();

        static void Main(string[] args)
        {
            name.Do(WriteName);
            name = Optional<string>.Some("Allan");
            name.Do(WriteName);

            Console.ReadLine();
        }

        static void WriteName(string name)
        {
            Console.WriteLine($"Hello {name}! You've learned how to avoid null checking!");
        }
    }
}