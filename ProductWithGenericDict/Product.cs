using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWithGenericDict {
    class Product {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string id, string name, decimal price) {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
