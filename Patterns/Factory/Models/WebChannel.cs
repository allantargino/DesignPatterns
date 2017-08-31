using Factory.Exceptions;
using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Models
{
    public class WebChannel : IStoreChannel
    {
        private ICollection<Product> _products;
        private WebChannelParameters _parameters;

        public WebChannel(IChannelParameters parameters)
        {
            _products = new List<Product>();
            _parameters = (WebChannelParameters)parameters;
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
            return $"Webstore at {_parameters.Endpoint}. Delivers at outside USA: {_parameters.DeliverOutsideUSA}";
        }
    }
}
