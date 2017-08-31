using Factory.Exceptions;
using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Models
{
    public class PhysicalChannel : IStoreChannel
    {
        private ICollection<Product> _products;
        private PhysicalChannelParameters _parameters;

        public PhysicalChannel(IChannelParameters parameters)
        {
            _products = new List<Product>();
            _parameters = (PhysicalChannelParameters) parameters;
        }

        public void Add(Product product)
        {
            if (!_products.Contains(product))
                _products.Add(product);
            else
                throw new InsertedProductException();
        }

        public void Sell(Product product)
        {
            if (_products.Contains(product))
                _products.Remove(product);
            else
                throw new NotInsertedProductException();
        }

        public override string ToString()
        {
            return $"Physical store at {_parameters.Address} in {_parameters.City}";
        }
    }
}
