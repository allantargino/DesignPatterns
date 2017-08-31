using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace State.Models
{
    public class IteractionParameter : IModelParameters
    {
        private int _iteractionsUpperLimit;

        public IteractionParameter(int interactionsUpperLimit)
        {
            _iteractionsUpperLimit = interactionsUpperLimit;
        }

        public object Parameters { get => _iteractionsUpperLimit; }
    }
}
