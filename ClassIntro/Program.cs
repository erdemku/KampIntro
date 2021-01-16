using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Erdem";
            int yas = 25;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Erdem Kuser";
            kurs1.IzlenmeOrani = 89;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Ergun Kuser";
            kurs2.IzlenmeOrani = 99;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Emre Can Kuser";
            kurs3.IzlenmeOrani = 74;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Fatma Kuser";
            kurs4.IzlenmeOrani = 100;

            Kurs[] kurslar = new Kurs[]
            {
                kurs1, kurs2, kurs3, kurs4
            };

            foreach (var k in kurslar)
            {
                Console.WriteLine(k.KursAdi + " : " + k.Egitmen);
            }

            /*Console.WriteLine("Kursun Adı: " + kurs1.KursAdi  + "\n" +
                "\nKursun Eğitmeni: " +  kurs1.Egitmen);*/
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
