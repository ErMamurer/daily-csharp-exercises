using System;

namespace Günlük_calısmalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temel filtreleme");

            int EsıkDeger = 50; // Eşik değer belirleniyor
            int KucukAdet = 0;
            double BuEsıtTop = 0;
            double kucukYuzde = 0;

            int[] sayılar = { 85, 40, 92, 15, 68, 7, 50, 44, 99 };

            for (int i = 0; i < sayılar.Length; i++)
            {
                if (sayılar[i] >= EsıkDeger)         // Eşik değere eşit veya büyük olan sayılar
                {
                    BuEsıtTop += sayılar[i];       // Eşik değere eşit veya büyük olan sayıların toplamı
                }

                else
                {
                    KucukAdet++;                      // Eşik değerden küçük olan sayıların adedi
                    kucukYuzde = (double)KucukAdet;  //  Eşik değerden küçük olan değerler.               
                }
            }
            kucukYuzde = (double)KucukAdet / sayılar.Length * 100;  // Eşik değerden küçük olan sayıların yüzdesi
            Console.WriteLine("Eşik değere eşit veya büyük olan sayılar: " + BuEsıtTop);
            Console.WriteLine("Eşik değerden küçük olan sayıların adedi: " + KucukAdet);
            Console.WriteLine("Eşik değerden küçük olan sayıların yüzdesi: " + kucukYuzde + "%");



        }
    }
}       
 









          


