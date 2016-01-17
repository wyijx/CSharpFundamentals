using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount {
   class Counter {
        public static int CountWords(string sentence) {
            return sentence.Split(' ').Length;
        }
    }

    static class MyUtilities {

        public static int WordCount(this string sentence) {
            return Counter.CountWords(sentence);
        }

        public static string[] GetFistWords(this string sentence, int num) {
            return sentence.Split(' ').Take(num).ToArray();
        }
    }
}
