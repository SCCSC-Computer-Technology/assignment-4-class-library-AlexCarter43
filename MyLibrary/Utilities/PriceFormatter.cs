using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Utilities
{
    class PriceFormatter
    {
        public static string FormatPrice(decimal price)
        {
            return price.ToString("$0.00");
        }
    }
}
