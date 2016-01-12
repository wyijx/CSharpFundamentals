using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Notes_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString());

            Customer Sally = new Customer
            {
                FirstName = "Sally",
                SecondName = "Williams",
                Age = 23,
                Birthday = "2028"
            };
            Customer Mike = new Customer
            {
                FirstName = "Mike",
                SecondName = "Harrison",
                Age = 10,
                Birthday = "2019"
            };

            Debug.Assert(Sally.Age == 23, "Sally is 23");
            Debug.Assert(Mike.Age == 10, "Mike is 10.");

            Console.WriteLine(String.Format("{0} {1} was born in {2} and is {3} years old", Sally.FirstName, Sally.SecondName, Sally.Birthday, Sally.Age.ToString()));
            Console.WriteLine(String.Format("{0} {1} was born in {2} and is {3} years old", Mike.FirstName, Mike.SecondName, Mike.Birthday, Mike.Age.ToString()));
            Console.ReadLine();
        }
    }

    class Customer
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Birthday { get; set; }
        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    _age = 0; //default
                    //throw new ArgumentOutOfRangeException("value", "Age cannot be less than zero.");
                }
                _age = value;
            }
        }
    }
}
