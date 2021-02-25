using System;
using System.Collections.Generic;
using System.Linq;

namespace ShowcaseWeb.Domain.Models
{
    public class Showcase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Volume { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime RemoveDate { get; set; }
        public List<Product> Products { get; }

        public Showcase(string name, int volume)
        {
            Name = name;
            Volume = volume;
            Products = new List<Product>();
        }

        public bool AddProduct(Product product)
        {
            var currentFilledVolume = Products.Sum(p => p.Volume);

            if (Volume > currentFilledVolume + product.Volume)
            {
                return false;
            }

            Products.Add(product);
            return true;
        }


    }
}
