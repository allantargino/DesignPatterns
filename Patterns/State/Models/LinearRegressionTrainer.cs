using State.Interfaces;
using System;
using System.Collections.Generic;

namespace State.Models
{
    public class LinearRegressionTrainer : ITrainer<LinearRegressionModel>
    {
        private ITrainerState<LinearRegressionModel> _state;

        public LinearRegressionTrainer(IModelParameters parameters, Action<LinearRegressionModel> callback)
        {
            var algorithm = new Func<IEnumerable<IInput>, LinearRegressionModel>(
                (_inputs) =>
                {
                    //Apply parameters
                    //Process input and create model

                    var numbers = (List<CartesianInput>)_inputs;
                    var p0 = (CartesianPoint) numbers[0].Input;
                    var p1 = (CartesianPoint) numbers[1].Input;

                    var a = p0.Y;
                    var b = (p1.Y - p0.Y) / (p1.X - p0.X);

                    return new LinearRegressionModel()
                    {
                        LinearParameters = new List<float>()
                        {
                            a,
                            b
                        }
                    };
                });

            _state = new InitializedState<LinearRegressionModel>(algorithm, callback);
        }

        public void Train(IEnumerable<IInput> inputs)
        {
            _state = _state.Train(inputs);
        }

        public void Cancel()
        {
            _state = _state.Cancel();
        }
    }
}
