using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtensions {
    static class Utilities {
        public static string GetRandom(this string[] a) {
            Random rnd = new Random();
            return a[rnd.Next(a.Length)];
        }
    }
}
