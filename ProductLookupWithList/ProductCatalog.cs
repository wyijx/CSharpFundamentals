using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLookupWithList {
    class ProductCatalog {

        public List<Product> Catalog { get; set; }

        public ProductCatalog() {
            Catalog = new List<Product>();
            Catalog.Add(new Product("AA", "Angry Apples", 1.99m));
            Catalog.Add(new Product("BB", "Butter Bees", 10.29m));
            Catalog.Add(new Product("QQ", "Crying Quitters", 0.99m));
        }

        public Product Lookup(string id) {
            foreach (var product in Catalog) {
                if(product.Id == id) {
                    return product;
                } 
            }
            return null;
        }
    }
}
