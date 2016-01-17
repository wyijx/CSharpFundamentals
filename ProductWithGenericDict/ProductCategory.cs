using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWithGenericDict {
    class ProductCategory {
        public Dictionary<string, Product> Catalog { get; set; }

        public ProductCategory() {
            Catalog = new Dictionary<string, Product>();
            Catalog.Add("bm", new Product("bm31", "Batman", 200.00m));
        }
        public Product Lookup(string L) {
            return Catalog[L];
        }
    }
}
