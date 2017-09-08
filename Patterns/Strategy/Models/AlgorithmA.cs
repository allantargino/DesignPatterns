using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Models
{
    class AlgorithmA : IAlgorithm
    {
        private int _constant;

        public void Init() => _constant = 0;

        public int Calculate(int x, int y) => _constant + x - y;
    }
}
