using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10, sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ? 999

            // int, decimal, float, double, bool = değer tipler
            // array(dizi), class, interface = referans tipler

            // bellekte stack ve heap diye iki değer var.
            // değer tipler stack de tanımlanır. orn ( sayı1 = 10 )
            // referans tiplerde adres atanır. 
        }
    }
}
