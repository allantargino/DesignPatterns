using State.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync(args).Wait();
        }

        static async Task MainAsync(string[] args)
        {
            var inputs = new List<CartesianInput>() // (x, y)
            {
                new CartesianInput(50, 25),
                new CartesianInput(100, 100)
            };
            int iterations = 5;

            var trainer = new LinearRegressionTrainer(iterations, Callback);
            trainer.Train(inputs);

            Console.ReadLine();
        }

        static void Callback(LinearRegressionModel model)
        {
            var list = (List<float>)model.LinearParameters;
            Console.WriteLine($"Result: y = {list[0]} + {list[1]} x");
        }
    }
}
