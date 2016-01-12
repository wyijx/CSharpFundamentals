using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWithConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var milk = new Product("Milk", 2.99m, 30);
            var apple = new Product("Apple", 0.79m, 25, "Delcious Red Apple");

            Console.WriteLine(milk.ToString());
            Console.WriteLine(apple.ToString());

            Console.ReadLine();
        }
    }
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int UnitsInSTock{ get; set; }
        public string Description { get; set; }

        public Product(string name, decimal price, int unitsInStock)
        {
            this.Name = name;
            this.Price = price;
            this.UnitsInSTock = unitsInStock;
        }
        public Product(string name, decimal price, int unitsInStock, string description)
        {
            this.Name = name;
            this.Price = price;
            this.UnitsInSTock = unitsInStock;
            this.Description = description;
        }
        public override string ToString()
        {
            if(Description == null)
            {
                return String.Format("{0} @ {1} - Stock {2}", this.Name, this.Price, this.UnitsInSTock);
            }
            else
            {
                return String.Format("{0} @ {1} - Stock {2} - Description: {3}", this.Name, this.Price, this.UnitsInSTock, this.Description);
            }
        }
    }
}
