using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLookupWithList {
    class Program {
        static void Main(string[] args) {
            ProductCatalog catalog = new ProductCatalog();

            var product = catalog.Lookup("AA");

            Console.WriteLine("Id: {0}", product.Id);
            Console.WriteLine("Name: {0}", product.Name);
            Console.WriteLine("Price: {0}",product.Price);
            Console.ReadLine();
        }
    }
}
