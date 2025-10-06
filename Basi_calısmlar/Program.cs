using System.ComponentModel.Design;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Basi_calısmlar
{
    internal class Program
    {
        static void Main(string[] args)   

        {
            Console.WriteLine("Kilo hesaplama programına hoşgeldiniz. Lütfen kilonuzu giriniz.");
            double kilo = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Lüttfen boyunuzu giriniz (metre cinsinden).");
            double boy =  Convert.ToDouble(Console.ReadLine());

            double vki = kilo / (boy*boy);
            Console.WriteLine($"Vücut kitle indeksiniz: {vki:F2}" );

            if (vki >= 35)
            {
                Console.WriteLine("Aşırı obezsiniz. Lütfen bir sağlık kuruluşuna başvurunuz.");
            }
            else if (vki >= 30)
            {
                Console.WriteLine("Obezsiniz.Lütfen diyet yapınız.");
            }
            else if (vki >= 25)
            {
                Console.WriteLine("Fazla kilolusunuz.Lütfen diyet yapınız.");
            }
            else if (vki <= 18.5)
            {
                Console.WriteLine("Zayıfsınız.Lütfen sağlıklı bir şekilde kilo alınız.");
            }
            else
            {
                Console.WriteLine("Kilonuz normal.");
            }

        }

    }
    
 }
