using System;
using System.Collections.Generic;
using System.Text;

namespace State.Interfaces
{
    public interface ITrainerState<M>
    {
        ITrainerState<M> Init(Func<IEnumerable<IInput>, M> algorithm, Action<M> callback);
        ITrainerState<M> Train(IEnumerable<IInput> inputs);
        ITrainerState<M> Cancel();
    }
}
