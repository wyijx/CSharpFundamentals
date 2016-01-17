using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtensions {
    class Program {
        static void Main(string[] args) {
            var newArray = new string[] {
                "HEADLINES AND EXTRAS",
                "WORLD AT WAR",
                "THE POWERBALL IS RIDICULOUS; EVERYONE TRIES TO WIN",
                "STAR WARS."
            };

            Console.WriteLine(newArray.GetRandom());
            Console.ReadLine();
        }
    }
}
