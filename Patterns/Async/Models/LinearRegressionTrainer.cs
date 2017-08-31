using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace State.Models
{
    public class LinearRegressionTrainer : ITrainerAsync<LinearRegressionModel>
    {
        int _iterations;

        public LinearRegressionTrainer(int iterations)
        {
            _iterations = iterations;
        }

        public void Train(IEnumerable<IInput> inputs)
        {
            throw new NotImplementedException();
        }

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public async Task<LinearRegressionModel> TrainAsync(List<IInput> inputs)
        {
            //Apply parameters
            //Process input and create model

            var numbers = inputs;
            var p0 = (CartesianPoint)numbers[0].Input;
            var p1 = (CartesianPoint)numbers[1].Input;

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
        }

        public Task CancelAsync()
        {
            return Task.FromResult(true);
        }
    }
}
