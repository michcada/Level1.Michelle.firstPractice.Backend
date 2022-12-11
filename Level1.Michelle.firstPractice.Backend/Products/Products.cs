using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1.Michelle.firstPractice.Backend.Products
{
    internal class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public int quantity;

        public Products(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}

//
