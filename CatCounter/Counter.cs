using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CatCounter {
    public class Counter {
        public static int CountCats(string s) {
            string pattern = @"(?i)cat[!s]?";
            int counter = 0;

            foreach (Match m in Regex.Matches(s, pattern)){
                counter++;
            }
            return counter;
        }
    }
}
