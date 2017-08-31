using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace State.Interfaces
{
    public interface ITrainerAsync<M>
    {
        Task<M> TrainAsync(List<IInput> inputs);
        Task CancelAsync();
    }
}
