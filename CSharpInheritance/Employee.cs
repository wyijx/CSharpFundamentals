using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritance {
    abstract class Employee {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(string first, string last) {
            this.FirstName = first;
            this.LastName = last;
        }

        public string ShowFullName() {
            return String.Format("{0} {1}", FirstName, LastName);
        }
    }

    class FullTimeEmployee: Employee {

        public FullTimeEmployee(string first, string last, int duration): base(first, last) {
            YearsEmployed = duration;
        }

        public int YearsEmployed { get; set; }       
    }

    class ContractEmployee: Employee {

        public ContractEmployee(string first, string last, int duration):base(first, last) {
            MonthsEmployed = duration;
        }

        public int MonthsEmployed { get; set; }
    }

}
