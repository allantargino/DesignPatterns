using Factory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Interfaces
{
    public interface IStoreChannel
    {
        void Add(Product product);

        void Sell(Product product);
    }
}
