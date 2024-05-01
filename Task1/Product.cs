using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Product
    {
        int code;
        string name;
        double price;

        public Product(int code, string name, double price)
        {
            this.Code = code;
            this.Name = name;
            this.Price = price;
        }

        public int Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
    }
}
