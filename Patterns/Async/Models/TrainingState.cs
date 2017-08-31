using State.Interfaces;
using System;
using System.Collections.Generic;

namespace State.Models
{
    class TrainingState<M> : ITrainerState<M>
    {
        private Func<IEnumerable<IInput>, M> _algorithm;
        private Action<M> _callback;

        public TrainingState(Func<IEnumerable<IInput>, M> algorithm, Action<M> callback)
        {
            _algorithm = algorithm;
            _callback = callback;
        }

        public ITrainerState<M> Init(Func<IEnumerable<IInput>, M> algorithm, Action<M> callback) => this;

        public ITrainerState<M> Train(IEnumerable<IInput> inputs) => this;

        public ITrainerState<M> Cancel() => new CancelState<M>(_algorithm, _callback);
    }
}
