using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var news = new string[] {
                "Martians Attack!", "Star Wars Episode VIII!", "DAVID BOWIE LIVES"
            };
            var rnd = new Random();

            Console.WriteLine(news[rnd.Next(3)]);
            Console.ReadLine();
        }
    }
}
