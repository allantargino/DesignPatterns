using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Models
{
    class StrategyAlgorithm : ITemplate
    {
        public IAlgorithm Algorithm { get; }

        public StrategyAlgorithm(IAlgorithm algorithm)
        {
            Algorithm = algorithm;
        }

        public void Perform(int x, int y)
        {
            Algorithm.Init();
            Console.WriteLine(Algorithm.Calculate(x,y));
        }
    }
}
