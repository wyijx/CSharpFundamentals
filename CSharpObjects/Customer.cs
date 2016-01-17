using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjects {
    class Customer {
        public string First { get; set; }
        public string Last { get; set; }
        public int Age { get; set; }
        public string BirthYear { get; set; }

        public Customer(string first, string last, int age, string year) {
            this.First = first;
            this.Last = last;
            this.BirthYear = year;
            this.Age = age;
            if(age < 0) { 
                this.Age = 0;
            } else {
                this.Age = age;
            }           
        }
    }
}
