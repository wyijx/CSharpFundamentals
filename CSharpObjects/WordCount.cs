using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjects {
    class Count {
        public static int CountWords(string s) {
            var c = s.Split(' ').Length;
            return c;
        }
    }
}
