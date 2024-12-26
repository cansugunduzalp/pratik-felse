using System;

namespace SayiKontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            // Örnek sayılar
            int[] sayilar = { 5, 10, 15, 8 };  // Bu sayıları manuel olarak tanımlıyoruz.

            // Sayıları döngüyle kontrol et
            foreach (int sayi in sayilar)
            {
                // Sayıyı ekrana yazdır
                Console.WriteLine($"Girilen sayı: {sayi}");

                // 1. kontrol: Sayı 10'a eşit, küçük veya büyük mü?
                if (sayi == 10)
                {
                    Console.WriteLine("Girilen sayı 10'a eşittir.");
                }
                else if (sayi < 10)
                {
                    Console.WriteLine("Girilen sayı 10'dan küçüktür.");
                }
                else
                {
                    Console.WriteLine("Girilen sayı 10'dan büyüktür.");
                }

                // 2. kontrol: Sayı çift mi, tek mi?
                if (sayi % 2 == 0)
                {
                    Console.WriteLine("Girilen sayı çifttir.");
                }
                else
                {
                    Console.WriteLine("Girilen sayı tektir.");
                }

                // Boş bir satır bırak
                Console.WriteLine();
            }

            // Programın kapanmasını engellemek için
            Console.ReadKey();
        }
    }
}
