using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3
{
    internal class Program
    {
        // Girilen tamsayının sıfır, pozitif ya da negatip olup olmadığını bulan midi code.
        static void Main(string[] args)
        {
            int number;
           
            while (true)
                // While true ise sonsuz döngü olur .
            {
                Console.WriteLine("Enter the random number: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                    Console.WriteLine("Number is Zero!");
                else if (number < 0)
                    Console.WriteLine("Number is Negative!");
                else if (number > 0)
                    Console.WriteLine("Number is Positive!");
           
            }
            
        }
    }
}
