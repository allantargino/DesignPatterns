using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Interfaces
{
    interface IAlgorithm
    {
        void Init();
        int Calculate(int x, int y);
    }
}
