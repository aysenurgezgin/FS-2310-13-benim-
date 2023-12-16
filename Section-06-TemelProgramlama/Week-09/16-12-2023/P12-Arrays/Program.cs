using System.Collections;

namespace P12_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[3];
            //int[] ages = new int[3] { 5, 3, 15 };
            //int[] sizes = { 5, 3, 2, 4, 5, 6, 3, 7 };

            //Console.WriteLine(sizes[3]) ;
            //Console.WriteLine(ages[6]);

            //int[] sayilar = new int[50];
  
            //Random random = new Random();
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = random.Next(1,101);
            //}

            //ArrayList tekSayilar = new ArrayList();
            //ArrayList ciftSayilar = new ArrayList();

            //foreach (int sayi in sayilar)
            //{
            //    if (sayi % 2 == 0)
            //    { 
            //        ciftSayilar.Add(sayi);
            //    }
            //    else
            //    {
            //        tekSayilar.Add(sayi);
            //    }
            //}
            //Console.WriteLine($"Çift Sayı Adedi: {ciftSayilar.Count}");
            //Console.WriteLine($"Tek Sayı Adedi: {tekSayilar.Count}");

            Random random = new Random();
            int[] tekSayilar = new int[5];
            int[] ciftSayilar = new int[5];
            for (int i = 0; i < 5; i++)
            {
                int sayi = 0;
                do
                {
                    sayi = random.Next(1, 101);
                } while (sayi % 2 != 1);
                tekSayilar[i] = sayi;

                do
                {
                    sayi = random.Next(1, 101);
                } while (sayi % 2 != 0);
                ciftSayilar[i] = sayi;
            }
            Console.WriteLine("TEK SAYILAR");
            foreach (int i in tekSayilar)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("ÇİFT SAYILAR");
            foreach (int i in ciftSayilar)
            {
                Console.WriteLine(i);
            }



            Console.ReadLine();
        }
    }
}
