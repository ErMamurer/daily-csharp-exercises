namespace Konsol_Temizleme_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rastgele dizi analizine hoşgeldiniz.");

            while (true) // Sonsuz döngü
            {
                Console.Clear();  // Consolu temizle
                Random rastgele = new Random(); // Random sınıfından rastgele nesnesi oluşturma
                int[] dizi = new int[10]; // 10 elemanlı boş bir dizi oluşturma

                for (int i = 0; i < dizi.Length; i++)  // Diznin uzunluğu kadar döngü
                {
                    dizi[i] = rastgele.Next(1, 101);  // 1 ile 100 arasında rastgele sayılar üretme

                    if (dizi[i] % 2 != 0) // Sayının tek olup olmadığını kontrol etme
                    {
                        Console.WriteLine("Tek sayı:" + dizi[i]); // Tek sayıları yazdırma
                        continue; // Döngünün başına dönme
                    }

                    else if (dizi[i] < 5) // Sayının 5'ten küçük olup olmadığını kontrol etme

                    {
                        Console.WriteLine("5'ten küçük sayı:" + dizi[i]);
                        continue;
                    }

                    else if (dizi[i] > 5) // Sayının 5'ten büyük olup olmadığını kontrol etme
                    {
                        Console.WriteLine("5'ten büyük sayı:" + dizi[i]);
                        continue;
                    }

                }

                Console.WriteLine("\n Yeni analiz için Enter'a, çıkmak için X'e basın"); // Kullanıcıdan giriş alma
                string cevap = Console.ReadLine(); // Kullanıcıdan giriş alma

                if (cevap.ToUpper() == "X") // Kullanıcı X'e basarsa döngüden çıkma
                {
                    Console.WriteLine("Programdan çıkılıyor...");   // Çıkış mesajı
                    break; // Döngüden çıkma
                }
            }
        }
    }
}