using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    internal class Program
    {
        // Girilen Fiyata KDV(%18) ekleyerek yazdırma mini kod.
        static void Main(string[] args)
        {
            double price, total;
            Console.WriteLine("Enter price to find price with tax");
            price = Convert.ToDouble(Console.ReadLine());
            total = price * 1.18;
            Console.WriteLine("{0} Price with tax: ", total);
            Console.ReadKey();

        }
    }
}
