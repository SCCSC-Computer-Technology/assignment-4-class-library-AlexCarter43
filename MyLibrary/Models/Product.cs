using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Models
{
    class Product
    {
        public string Product_Number { get; set; }
        public decimal Price { get; set; }
        public int Units_On_Hand { get; set; }
        public string Description { get; set; }
    }
}
