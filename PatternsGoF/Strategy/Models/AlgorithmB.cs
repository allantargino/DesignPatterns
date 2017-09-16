using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Models
{
    class AlgorithmB : IAlgorithm
    {
        private int _constant;

        public void Init() => _constant = 10;

        public int Calculate(int x, int y) => _constant + x + y;
    }
}
