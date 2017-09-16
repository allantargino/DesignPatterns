using NullObject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject.Models
{
    class NonePromotion : IPromotion
    {
        public double CalculateNewSalary(double salary) => salary;
    }
}
