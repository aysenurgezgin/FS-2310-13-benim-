namespace P04_RefereanceTypes
{
    class Product
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
          /*  int number1 = 50;
            Console.WriteLine(number1);*/

            Random random = new Random();
            int sayi1 = random.Next();

            Console.WriteLine(sayi1);


            Product urun1 = new Product();

             Console.ReadLine();
             
           
           
            //tipi random olan bir değişekn olştrup
                //primitiv tipler stackte tutuluyor (int gibi)
                //heap kısmında belli adreslere belli adresler veriliyor.referans adres referans tipli değişken deniliyor (class yazılacarak tutuluyorsa) refere ediyor
                //miras alma olayına bir bak.
               /* uygulama kapanınca kapanr primtiv/ referans kaılr*/
        }
    }
}