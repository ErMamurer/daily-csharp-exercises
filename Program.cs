namespace Rastgele_Dizi_Analiz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rastgele = new Random(); // Random sınıfından rastgele nesnesi oluşturuyorum.
            int[] sayı = new int[10]; // 10 elemanlı boş! bir dizi oluşturuyorum.

            for (int i = 0; i < sayı.Length; i++)   // Döngü, dizinin uzunluğu kadar dönsün.
            {                                      // rastgele nesnesi ile .next metodu kullanarak-
                sayı[i] = rastgele.Next(1, 100);  // 1 ile 100 arasında rastgele sayılar oluştur ve dizinin elemanlarına ata.
                Console.WriteLine(sayı[i]);      // Oluşturulan sayıları ekrana bastır.
                if (sayı[i] % 2 != 0)           // Koşul, tek sayı ise, 2'ye bölümünden kalan 0 değilse.
                {
                    Console.WriteLine("Tek sayılar:" + sayı[i]);  // Tek sayıları yazdır.
                    continue; // Döngünün başına dön.
                }

                else if (sayı[i] <= 5)  // Koşul 5'ten küçük ise.
                {
                    Console.WriteLine("5'ten küçük sayı:" + sayı[i]); // 5'ten küçük sayıları yazdır.
                    continue; // Döngünün başına dön.
                }
                else  // Koşul 5'ten büyük ise.
                {
                    Console.WriteLine("5'ten büyük sayı:" + sayı[i]); // 5'ten büyük sayıları yazdır.
                }
            }

        }
    }
}
