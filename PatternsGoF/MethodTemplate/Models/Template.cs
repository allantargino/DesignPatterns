using MethodTemplate.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MethodTemplate.Models
{
    abstract class Template : ITemplate
    {
        public void Perform()
        {
            Connect();
            Get();
            Close();
        }

        public virtual void Connect()
        {
            Console.WriteLine("Connecting...");
        }

        public abstract void Get();

        public virtual void Close()
        {
            Console.WriteLine("Closing...");
        }
    }
}
