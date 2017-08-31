using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Exceptions
{
    public class NotInsertedProductException : Exception
    {
        public override string Message => "Product not inserted on the list.";
    }
}
