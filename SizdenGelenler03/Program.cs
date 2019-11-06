using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SizdenGelenler03
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rasgeleUretici = new Random();
            int sayi1, sayi2, cevap;
            int puan = 0, dogruCevap = 0, yanlisCevap = 0;
            string okunan;

            Console.WriteLine("Aşağıdaki işlem sonuçlarını giriniz: ");

            oyunBasi:

            sayi1 = rasgeleUretici.Next(1, 100);
            sayi2 = rasgeleUretici.Next(1, 100);
            Console.Write("{0} + {1} = ?", sayi1, sayi2);

            cevapAlma:

            okunan = Console.ReadLine();
            if (!Int32.TryParse(okunan, out cevap))
            {
                Console.WriteLine("Girilen değer doğru formatta değil.");
                goto cevapAlma;
            }

            if (cevap == sayi1 + sayi2)
            {
                Console.WriteLine("Tebrikler Bildiniz");
                dogruCevap++;
                puan += 5;
            }
            else
            {
                Console.WriteLine("Üzgünüm Bilemediniz");
                yanlisCevap++;
                puan -= 2;
            }

            Console.WriteLine("Tekrar oynamak istiyor musunuz? (e / E)");
            okunan = Console.ReadLine();
            if (String.Compare(okunan, "e", StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                goto oyunBasi;
            }

            Console.WriteLine("Puan: {0}\nDoğru Cevap: {1}\nYanlış Cevap: {2}", puan, dogruCevap, yanlisCevap);
            Console.ReadLine();
        }
    }
}
