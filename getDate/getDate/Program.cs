using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getDate
{
    class Program
    {
        static void Main(string[] args)
        {
            //request input
            Console.Write("Enter a date using MM/DD/YYYY Format: ");

            //get input
            var userDate = Console.ReadLine();

            //Covert userDate to a DateTime object called date.
            DateTime date = Convert.ToDateTime(userDate);
            
            //log our Input Date int long DateString format
            Console.WriteLine(date.ToLongDateString());

            //pause
            Console.ReadLine();
        }
    }
}
