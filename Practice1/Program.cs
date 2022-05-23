using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Program
    {
        // Örnek 1
        /* Birbirinden farklı olarak girilen iki adet sayıdan, en büyük olanı bulup gösteren mini code ?
         */
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("Lütfen birinci: sayıyı giriniz: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            number2=Convert.ToInt32(Console.ReadLine());

            if (number1>number2)
            {
                Console.WriteLine("Birinci sayı büyüktür.");
            }
            else if (number1<number2)
            {
                Console.WriteLine("İkinci sayı büyüktür. ");
            }
            
            Console.WriteLine(number1>number2 ? "Number1 sayı büyüktür." : "Number2 sayı büyüktür.");
            // single line olarak yazımı budur.
           

            Console.ReadKey();
            
          
        }
    }
}
