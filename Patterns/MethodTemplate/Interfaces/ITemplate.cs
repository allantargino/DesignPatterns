using System;
using System.Collections.Generic;
using System.Text;

namespace MethodTemplate.Interfaces
{
    interface ITemplate
    {
        IMethods Methods { get; }
        void Perform();
    }
}
