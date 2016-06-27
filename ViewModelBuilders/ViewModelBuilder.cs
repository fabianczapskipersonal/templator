using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ebay.ViewModelBuilders
{
    public abstract class ViewModelBuilder<T>
    {
        public abstract T Build(string productName);
    }
}