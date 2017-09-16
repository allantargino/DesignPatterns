using NullObject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject.Models
{
    class Employee
    {
        public string Name { get;  }
        public double Salary { get; }

        private IPromotion Promotion { get; }

        public Employee(string name, double salary, IPromotion promotion)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(name);
            if (salary <= 0) throw new ArgumentOutOfRangeException(nameof(salary), "Salary should be stricted positive.");
            if (promotion == null) throw new ArgumentNullException(nameof(promotion));

            Name = name;
            Salary = salary;
            Promotion = promotion;
        }

        public Employee GetPromotion() => new Employee(this.Name, Promotion.CalculateNewSalary(this.Salary), Promotion);
    }
}
