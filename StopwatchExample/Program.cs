using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchExample {
    class Program {
        static void Main(string[] args) {

            var randomNumbers = new List<int>();
            var rand = new Random();

            for (int i = 0; i < 10000; i++) {
                randomNumbers.Add(rand.Next(1000));
            }

            var stopwatch = new Stopwatch();

            foreach (var pair in CountDuplicates(randomNumbers)) {
                Console.WriteLine("{0} has {1} duplicates,", pair.Key, pair.Value);
            }

            stopwatch.Stop();
            Console.WriteLine("Total time was {0} milliseconds", stopwatch.ElapsedMilliseconds);
            Console.ReadLine();
        }

        static Dictionary<int, int> CountDuplicates(List<int> numbers) {
            
            Dictionary<int, int> dups = new Dictionary<int, int>();

            foreach (var num in numbers) {
                if (dups.ContainsKey(num)) {
                    dups[num]++;
                } else {
                    dups[num] = 1;
                }
            }
            return dups;
        }
    }
}
