using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "java";

            //Array - dizi
            string[] kurslar = new string[] {"yazılım geliştirici yetiştirme kampı",
                                             "programlamaya başlangıç için temel kurs",
                                             "Java", "Pyton", "C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs/*takma isim kurslardaki elemanları dolasmak ıcın verılır*/
                     in kurslar) // foreach dizileri tek tek dolasmaya yarıyor
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu -- footer");
        }
    }
}
