using MethodTemplate.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MethodTemplate.Models
{
    class Template<Method> : ITemplate
        where Method:IMethods
    {
        public IMethods Methods { get; }

        public Template(Method method)
        {
            Methods = method;
        }

        public void Perform()
        {
            Methods.Connect();
            Methods.Get();
            Methods.Close();
        }
    }
}
