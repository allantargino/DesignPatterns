using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace State.Models
{
    class InitState<M> : ITrainerState<M>
    {
        private Func<IEnumerable<IInput>, M> _algorithm;
        private Action<M> _callback;

        public InitState(Func<IEnumerable<IInput>, M> algorithm, Action<M> callback)
        {
            _algorithm = algorithm;
            _callback = callback;
        }

        public ITrainerState<M> Init(Func<IEnumerable<IInput>, M> algorithm, Action<M> callback) => new InitState<M>(algorithm, callback);

        public ITrainerState<M> Train(IEnumerable<IInput> inputs)
        {
            Task.Run(() =>
            {
                //TODO: Implement CancellationToken with Cancel()
                M model = _algorithm(inputs);
                _callback(model);
            });
            return new TrainingState<M>(_algorithm, _callback);
        }

        public ITrainerState<M> Cancel() => this;

    }
}
