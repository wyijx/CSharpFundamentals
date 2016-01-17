using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithTests {
    public class Calculator {

        public double AddNums(params double[] num) {
            double sum = 0;
            foreach(double val in num) {
                sum += val;
            }
            return sum;
            //return num.Sum();
        }

        public double Exp(double b, double exp) {
            return Math.Pow(b, exp);
        }

        public double SubNums(double num1, double num2) {
            //num1 must be greater than num2
            return num1 - num2;
        }

        public double MultNums(double num1, double num2) {
            return num1 * num2;
        }

        public double DivNums(double num1, double num2) {
            //num 1 must be greater than num2
            return num1 / num2;
        }
    }
}
