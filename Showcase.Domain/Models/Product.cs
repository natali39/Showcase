using System;
using System.Collections.Generic;
using System.Text;

namespace ShowcaseWeb.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Volume { get; set; }

        public Product(string name, int value)
        {
            Name = name;
            Volume = value;
        }
    }
}
