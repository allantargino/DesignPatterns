using NullObject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject.Models
{
    class HigherPromotion : IPromotion
    {
        public double CalculateNewSalary(double salary) => salary * 1.2;
    }
}
