using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyMath
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Math();
            Console.WriteLine("Two Operators Supplied 6, 2: {0}", test.DoSomething(6, 2).ToString());
            Console.WriteLine("Three Operators Supplied 3, 3, and 3: {0}", test.DoSomething(3, 3, 3).ToString());
            Console.WriteLine("Four Operators Supplied 2, 2, 2, and 2: {0} ", test.DoSomething(2, 2, 2, 2).ToString());

            Console.ReadLine();
        }
    }
    class Math
    {
        public int DoSomething(int val1, int val2)
        {
            return val1 / val2;
        }
        
        public int DoSomething(int val1, int val2, int val3)
        {
            return val1 + val2 + val3;
        }
        public int DoSomething(int val1, int val2, int val3, int val4)
        {
            return (val1 * val2 * val3 * val4);
        }
    }
}
