using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var Alice = new Customer();

            //Setup Checking ACCT object data-member
            Alice.Checking.Id = "0001";
            Alice.Checking.Type = "Checking";
            Alice.Checking.Amount = 100;
            Alice.Checking.IsOpen = true;

            Alice.Savings.Id = "0002";
            Alice.Savings.Type = "Savings";
            Alice.Savings.Amount = 0;
            Alice.Savings.IsOpen = false;

            //pause
            Console.ReadLine();
        }
    }
    class Customer
    {
            public Account Checking { get; set; }
            public Account Savings { get; set; }
            
            public Customer()
            {
                this.Checking = new Account();
                this.Savings = new Account();
            }
    }
    class Account
    {
        public string Id { get; set; }
        public string Type{ get; set; }
        public int Amount { get; set; }
        public bool IsOpen { get; set; }
    }
}
