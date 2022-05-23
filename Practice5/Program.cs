using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    internal class Program
    {
        // Girilen 5 sayının toplamı ve ortalaması
        static void Main(string[] args)
        {
            Yol1();          
            Yol2();
            Yol3();
            
            Console.ReadLine();
        }
        static void Yol1()
        {
            double number1, number2, number3, number4, number5, sum;
            double avg;
            Console.WriteLine("Sizden 5 adet sayı alacağız toplamını ve ortalamasını vereceğiz: ");
            Console.WriteLine("1. sayı:  ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2. sayı:  ");
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("3. sayı:  ");
            number3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("4. sayı:  ");
            number4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("5. sayı:  ");
            number5 = Convert.ToDouble(Console.ReadLine());
            sum = number1 + number2 + number3 + number4 + number5;
            avg = sum / 5;
            Console.WriteLine("Sayıların Toplamı: {0}\nSayıların ortalaması: {1}", sum, avg);
        }
        static void Yol2()
        {
            double sum = 0, avg = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine((i + 1) + ". Sayıyı giriniz.");
                double number = Convert.ToDouble(Console.ReadLine());
                sum += number;
            }
            avg = sum / 5;
            Console.WriteLine("Sayıların Ortalaması: {0}\nSayıların toplamı: {1}", avg, sum);
        }
        static void Yol3()
        {

            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write((i + 1) + ". sayıyı giriniz:");
                sum += Convert.ToDouble(Console.ReadLine());
            }
            double avg = sum / 10;
            Console.WriteLine("Toplam={0}\nOrtalama={1}", sum, avg);
            Console.ReadKey();
        }
    }
}
