using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace State.Interfaces
{
    public interface ITrainer<M>
    {
        void Train(IEnumerable<IInput> inputs);
        void Cancel();
    }
}
