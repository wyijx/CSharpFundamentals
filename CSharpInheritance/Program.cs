using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritance {
    class Program {
        static void Main(string[] args) {
            var bill = new FullTimeEmployee("Bill", "Gates", 5);
            var steve = new ContractEmployee("Steve", "Jobs", 2);

            Debug.Assert(bill.ShowFullName() == "Bill Gates");
            Debug.Assert(bill.YearsEmployed == 5, "Bill has been with the company 5 years.");

            Debug.Assert(steve.ShowFullName() == "Steve Jobs");
            Debug.Assert(steve.MonthsEmployed == 2, "{0} has been with teh company 2 months.", steve.ShowFullName());

            Console.ReadLine();
        }
    }
}
