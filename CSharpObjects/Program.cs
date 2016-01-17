using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjects {
    class Program {
        static void Main(string[] args) {
            var milk = new Product() {
                Name = "2% Milk",
                Price = 2.99m,
                Description = "Milky milk",
                UnitsInStock = 5
            };
            Console.WriteLine("Name: {0}\nPrice: {1}", milk.Name, milk.Price);

            var sally = new Customer("Sally", "Williams", 23, "2028");
            var mike = new Customer("Mike", "Harrison", 10, "2019");

            Console.WriteLine("{0} {1} is {2} and was born in {3}", mike.First, mike.Last, mike.Age, mike.BirthYear);
            Console.WriteLine("{0} {1} is {2} and was born in {3}", sally.First, sally.Last, sally.Age, sally.BirthYear);

            var testString = "This string is a test.";

            Console.WriteLine(Count.CountWords(testString).ToString());
            Console.ReadLine();
        }
    }
}
