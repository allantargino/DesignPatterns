using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Models
{
    public class PhysicalChannelCreator : IChannelCreator
    {
        public IStoreChannel Create(IChannelParameters parameters)
        {
            return new PhysicalChannel(parameters);
        }
    }
}
