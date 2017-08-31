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
            // obtem dados iniciais
            var inputs = new CartesianInput(new CartesianPoint(50, 25), new CartesianPoint(100, 100));
            
            // usando uma regressao linear simples
            var trainer = new LinearRegressionTrainer(iterations: 5);

            // treina modelo
            var model = await trainer.TrainAsync(inputs);

            // processa resultado
            var list = (List<float>)model.LinearParameters;
            Console.WriteLine($"Result: y = {list[0]} + {list[1]} x");
            
            Console.ReadLine();
        }
    }
}
