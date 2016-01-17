using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritance {
    abstract class Car {
        public string VIN { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public decimal CalculateTax() {
            return this.Price * 0.08m;
        }
    }

    class NewCar : Car {
        public int WarrantyMiles { get; set; }
    }

    class UsedCar : Car {
        public int Miles { get; set; }
    }
        
    class CertifiedUsedCar: UsedCar {
        public int WarrantyMonths { get; set; }
    }


}
