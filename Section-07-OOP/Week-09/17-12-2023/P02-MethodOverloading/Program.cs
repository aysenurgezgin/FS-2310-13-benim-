namespace P02_MethodOverloading
{
    internal class Program
    {

        /// <summary>
        /// Bu metot, aldığı iki tam sayıyı toplayıp sonucu tamsayı olarak döndürür.
        /// </summary>
        /// <param name="sayi1">Toplanacak ilk tam sayı değer</param>
        /// <param name="sayi2">Toplanacak ikinci tam sayı değer</param>
        /// <returns>Geriye tam sayı bir değer döndürür</returns>
        static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        static int Topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }
        static double Topla(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Topla(5,6));
            Console.WriteLine(Topla(4,7,8));
            
            Console.ReadLine();
        }
    }
}
