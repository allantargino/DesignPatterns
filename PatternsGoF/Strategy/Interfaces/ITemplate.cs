using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Interfaces
{
    interface ITemplate
    {
        IAlgorithm Algorithm { get; }
        void Perform(int x, int y);
    }
}
