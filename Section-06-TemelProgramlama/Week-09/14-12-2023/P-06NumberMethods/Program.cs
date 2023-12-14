namespace P_06NumberMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*    int number1 = 40;
                int number2 = 60;
                Console.WriteLine($"En Küçük: {Math.Min(number1,number2)}");
                Console.WriteLine($"En Büyük: {Math.Max(number1, number2)}");
    */

            /*   int sayi = 4;
               int us = 2;
               int sonuc = Convert.ToInt32(Math.Pow(sayi, us));
               Console.WriteLine(sonuc);
   */
            //(convert )sınıfı döüştürme yaparken değer kaybetim(tipini değiştirmek istiyordum) c# risk alıyoesun diyor  double 64 bitlik
            //veri kaybını göze alamıyor c#  ( int 32 bitlik yer kaplıyor.) int16 short , int 64 long tip dönüişümü yaparken 


            //kullanıcıdan veri girme komutu girilenn değeri herhangi birşeyw atılmıyor(geri döneni kullanmak)

            //debug saatıru
            /*      Console.Write("Bir sayı giriniz: ");
                  int number1 =Convert.ToInt32(Console.ReadLine());

                  Console.Write("Bir sayı daha giriniz: ");
                  int number2 = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine(number1+number2);*/

            // kullanıcan taban ve üst sayılarını alıp tabanın üssüncü kuvvetini hesaplayarak konsola yazdıran komut;

            /*     
                Console.Write("Taban bilgisini giriniz: ");
                 int taban = Convert.ToInt32(Console.ReadLine();
                 Console.Write("Üs bilgilerini giriniz: ");
                 int üst = Convert.ToInt32(Console.ReadLine());
            Devamını yaz
                 Console.Write();
     */

            double sayi = 5.493486;
            Console.WriteLine(sayi);
            Console.WriteLine($"Ceiling: {Math.Ceiling(sayi)}");
            Console.WriteLine($"{Math.Ceiling(sayi)}");
            Console.WriteLine($"{Math.Ceiling(sayi)}");

            //Eksiklerini taamaş
            Console.ReadLine();


        }
    }
}