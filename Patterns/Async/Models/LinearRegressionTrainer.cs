using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace State.Models
{
    public class LinearRegressionTrainer : ITrainerAsync<CartesianInput, LinearRegressionModel>
    {
        int _iterations;

        public LinearRegressionTrainer(int iterations)
        {
            _iterations = iterations;
        }

        public async Task<LinearRegressionModel> TrainAsync(CartesianInput inputs)
        {
            //Apply parameters
            //Process input and create model

            var p0 = inputs.P1;
            var p1 = inputs.P2;

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

        public void Cancel()
        {
        }
    }
}
