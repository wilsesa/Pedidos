using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pedidos
{
    public class Product
    {
        public string name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            this.name = name;
            Price = price;
        }
    }
}