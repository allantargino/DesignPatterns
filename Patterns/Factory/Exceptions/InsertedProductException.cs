using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Exceptions
{
    public class InsertedProductException : Exception
    {
        public override string Message => "Product already inserted on the list.";
    }
}
