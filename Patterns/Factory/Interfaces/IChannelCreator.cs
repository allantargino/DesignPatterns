using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Interfaces
{
    public interface IChannelCreator
    {
        IStoreChannel Create(IChannelParameters parameters);
    }
}
