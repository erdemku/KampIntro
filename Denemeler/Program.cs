using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product u1 = new Product();
            u1.Adi = "Elma";
            u1.Fiyati = 15;
            u1.Aciklama = "Amasya Elması";

            Product u2 = new Product();
            u2.Adi = "Karpuz";
            u2.Fiyati = 80;
            u2.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] { u1,u2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine("Ürün Adi\t: " + urun.Adi);
                Console.WriteLine("Ürün Fiyatı\t: " + urun.Fiyati);
                Console.WriteLine("Ürün Acıklaması\t: " + urun.Aciklama);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("-----------------Metotlar-------------------");

            //instance- ornek
            //encapsulation

            SepetManager sm = new SepetManager();
            sm.Ekle(u1);
            sm.Ekle(u2);

            sm.Ekle2("Armut", "Yeşil Armut", 12, 34);
            sm.Ekle2("Elma", "Kırmızı Elma", 42, 69);
            sm.Ekle2("Karpuz", "Diyarbakır Karpuzu", 90, 23);
        }
    }
}
