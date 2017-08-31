using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Models
{
    public class WebChannelCreator : IChannelCreator
    {
        public IStoreChannel Create(IChannelParameters parameters)
        {
            return new WebChannel(parameters);
        }
    }
}
