using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount {
    class Program {
        static void Main(string[] args) {
            string test = "Test string using a few words";

            foreach(var word in test.GetFistWords(3)) {
                Console.WriteLine(word);
            }

            Debug.Assert(Counter.CountWords(test) == 6, "Checking Counter");
            Debug.Assert(test.WordCount() == 6, "Should be 4 words long");
        }
    }
}
