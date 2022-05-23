using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Program
    {
        // Girilen vize ve final notlarına göre öğrencinin dersten geçip geçmediğini bulan mini kod.
        static void Main(string[] args)
        {
            float visa,final,avg;
            Console.WriteLine("Enter the visa grade: ");
            visa = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the final grade : ");
            final = float.Parse(Console.ReadLine());
            avg = Convert.ToInt16(visa*0.4+final*0.6);
            Console.WriteLine();
            Console.WriteLine("{0} average grade.", avg);
            if (avg >= 60)
                Console.WriteLine("passed");
            else
                Console.WriteLine("failed");
            Console.WriteLine(avg>=60 ? "Single line passed" :"Single line failed" );
            Console.ReadKey();
        }
    }
}
