using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[100];

            foreach(var num in nums)
            {
                if (num % 7 == 0)
                {
                    Console.WriteLine(num.ToString());
                }
            }
            Console.ReadLine();
        }
    }
}
