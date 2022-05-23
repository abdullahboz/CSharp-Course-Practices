using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesReflection
{
    // HATALARIM VARSA VE YA İYİLEŞTİRMELER YAPILACAKSA GERİ DÖNÜŞ YAPARSANIZ SEVİNİRİM.
    internal class Program
    {
        //Reflection temelini Csharp-Course bölümünden inceleyebilirsiniz.
        //https://www.gencayyildiz.com/blog/cta-system-reflection-kutuphanesi/
       
        static void Main(string[] args)
        {
            Student student = new Student();
            student.GetType().GetProperties().ToList().ForEach(p => 
            // student nesnemizi oluşturduktan sonra tipini getiriyoruz, özellikleri getiriyoruz, listeliyoruz, foreach ile kontrol edip yazdırıyoruz.
            {
                Console.WriteLine(p.Name);
            });
            student.GetType().GetMethods().ToList().ForEach(s => 
            // student nesnesinin tipini, methodunu, liste halinde getirip foreach ile lambda kullanarak getiriyoruz.
            {
                if (s.Name == "CalculateSalary")
                {
                    var result = s.Invoke(student,new object[] { 2, 4 });
                    // eğer s.Name bizim maaş metodumuza eşit ise Invoke ile çalıştırıp içine nesnemizi ve yeni nesnemizi atıyoruz.
                    // yeni nesnemiz bir array ve içine saat ile ücreti atıyoruz. bunlar aşağıdaki metottaki gibi çarpılıyor var sonucta set ediliyor.
                    Console.WriteLine(result);

                }
            });
            student.GetType().GetProperties().ToList().ForEach(p => 
            
            {
                if (p.Name == "StudentNumber")
                    p.SetValue(student, "21535153153");
                // koşul sağlanıyor ise nesnemize öğrenci noyu set ediyoruz.
                else if (p.Name == "FirstName")
                    p.SetValue(student, "Abdullah");
                // "" ""            ""   "" 
                else
                    p.SetValue(student,"Boz");
                // "" ""            ""   "" 
            });
            Console.WriteLine($"{student.StudentNumber},{student.FirstName},{student.LastName}");
            // Yanlış bilmiyorsam dolar işareti koleksiyonları, dizileri düzenlemek için kullanılıyor. 
            Student student1 = new Student() {StudentNumber="21535153153", FirstName="Abdullah",LastName="Boz"};
            // burada student1 nesnemizi oluşturup değerini manuel bir biçimde atıyoruz.
            student1.GetType().GetProperties().ToList().ForEach(p => 
            {
                if(p.Name=="StudentNumber")
                    Console.WriteLine($"Student No: "+p.GetValue(student1));
                // değeri getirip yazdırıyoruz.
                else if(p.Name=="FirstName")
                    Console.WriteLine($"First Name: " + p.GetValue(student1));
                // değeri getirip yazdırıyoruz.
                else
                    Console.WriteLine($"Last Name: " + p.GetValue(student1));
                // değeri getirip yazdırıyoruz.
            });


            Console.ReadLine();
        }
    }
    class Student
    {
        public string StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double CalculateSalary (int Hour, double Price ) => Hour * Price;
    }
    static class Operations
        // İşlemler class'ımızı tanımlıyoruz Processes , transactions artık hangisi doğruysa isim olarak.
    {
        static public T Operation<T>(this T obje, T newObje) where T : class, new()
            
        {
            obje.GetType().GetProperties().ToList().ForEach(p => 
            // objemizin tipini getiriyoruz, özelliklerini getirip listeliyoruz, foreach ile kontrol ediyoruz
            {
                newObje.GetType().GetProperties().ToList().ForEach(p2 =>
                // iç içe for mantığı gibi 
                {
                    if(p.Name == p2.Name)
                        p.SetValue(obje, p2.GetValue(newObje));
                    //eğer isimler eşit ise objeye set edip, new objeyi getiriyoruz.
                });
            });
            return obje;
        }
        static public T Operation<T>(this T obje) where T : class, new()
        {
            T newObje = new T();
            obje.GetType().GetProperties().ToList().ForEach(p => 
            {
                p.SetValue(newObje, "Abdullah");
                // manuel set ediyoruz.
                // yukarıda işleminden dolayı böyle bir set işlemi uyguladık.
            });
            return newObje;
        }
    }
}
