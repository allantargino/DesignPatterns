using Strategy.Models;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10;
            new StrategyAlgorithm(new AlgorithmA()).Perform(x,y);
            new StrategyAlgorithm(new AlgorithmB()).Perform(x,y);

            Console.ReadLine();
        }
    }
}
