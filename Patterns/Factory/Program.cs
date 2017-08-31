using Factory.Interfaces;
using Factory.Models;
using System;
using System.Collections.Generic;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var channels = new List<IStoreChannel>();

            var webCreator = new WebChannelCreator();
            var physicalCreator = new PhysicalChannelCreator();

            channels.Add(
                webCreator.Create(new WebChannelParameters()
                {
                    Endpoint = new Uri("https://store.com"),
                    DeliverOutsideUSA = true
                }));

            ////Error due wrong parameters:
            //channels.Add(
            //    physicalCreator.Create(new WebChannelParameters()
            //    {
            //        Endpoint = new Uri("https://store.com"),
            //        DeliverOutsideUSA = true
            //    }));

            channels.Add(
                physicalCreator.Create(new PhysicalChannelParameters()
                {
                    Address = "Street 101",
                    City = "Seattle"
                }));

            foreach (var channel in channels)
                Console.WriteLine(channel.ToString());

            Console.ReadLine();
        }
    }
}
