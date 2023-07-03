using System;
using System.Collections.Generic;
using System.Text;

namespace Vshop.view
{
    class Products
    {
        public string img { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string price { get; set; }
        public string buy { get; set; }

        internal static object Where(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
