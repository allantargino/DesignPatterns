using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Models
{
    public class WebChannelParameters:IChannelParameters
    {
        public Uri Endpoint { get; set; }
        public bool DeliverOutsideUSA { get; set; }
    }
}
