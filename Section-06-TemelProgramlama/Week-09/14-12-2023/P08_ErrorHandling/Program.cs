namespace P08_ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //uygukamalarımız çalıştıkları esnada bir takım hatalardan dolayı duarbilir. Bu tür hatalara Run Timr Errors(Çalışma Zamanı Hataları)denir.
            //Run Time Errorsı kontrol altına alabilmek için Try-CatchFinnaly yapısını kullanacağız.4

            /*
             * try {
             * ÇAlılmasını bekledğimiz kudları bauraya yazcağız.Yani hata verme olasılığı olan kodlar.Dolayısıyla  buraya yazdığımız kodları şu şekilde düşünebiliriz:
             * Bu kodalrı çalıştıryı Dene! ÇAlışıyorsa hiçbir sorun olmadan devam eder, yani catch scope'unu atlar ,çalıştırmaz. Çalışmıyorsa , hata vatsa catch scope'unu atlar,çalıştırlmaz. Çalışmıyorsa , hata varsa catch scope'ına geçer.
             * }
             * catch
             * {
             * Eğer try scope'undaki kodda bir hata meydana  gelirse bu bölümdeki kodalr çalışır.
             * }
             * 
             * 
            *
             * 
             * 
             * 
             * 
             * */




            #endregion

            #region
            /*  Console.Write("Lütfen karesi alanacak sayıyı giriniz: ");
              try
              {
                  int sayi = Convert.ToInt32(Console.ReadLine());
                  int sonuc = Convert.ToInt32(Math.Pow(sayi, 2));
                  Console.WriteLine(sonuc);
              }
              catch (Exception ex)
              {

                  Console.WriteLine(ex.Message);
              }*/

            #endregion



            #region
            try
            {
                Console.WriteLine("Bölünen: ");
                int bolunen = int.Parse(Console.ReadLine());
                Console.WriteLine("Bölen: ");
                int bolen = int.Parse(Console.ReadLine());
                int sonuc = bolunen / bolen;
                Console.WriteLine($"{bolunen} / {bolen}= {sonuc}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("0'a bölme yapılamaz!");

            }
            catch(FormatException ex)
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata var!" +
                    "");
            }


            //bir string i sayıya çevimre sadace bu kısım da geçerli=parse

            #endregion
            Console.ReadLine();
        }
    }
}