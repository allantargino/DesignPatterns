using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Models
{
    public class PhysicalChannelParameters : IChannelParameters
    {
        public string Address { get; set; }
        public string City { get; set; }
    }
}
