using Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Models
{
    class Manager : IEmployee
    {
        public string Name { get; }
        private IList<IEmployee> _employees;

        public Manager(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            Name = name;
            _employees = new List<IEmployee>();
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is working!");
            foreach (var e in _employees)
                e.Work();
        }

        public void Add(IEmployee employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            _employees.Add(employee);
        }

        public void Remove(IEmployee employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            _employees.Remove(employee);
        }

        public IEnumerable<IEmployee> GetChild() => _employees;

    }
}