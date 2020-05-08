using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice("6", "Alex", "Fox") { Article = "Iphone8", Quantity = "6" };
            invoice.CostCalculation(true);

            Console.ReadLine();
        }
    }
}
