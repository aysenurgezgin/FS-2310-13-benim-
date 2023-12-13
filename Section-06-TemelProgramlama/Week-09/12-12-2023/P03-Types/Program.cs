namespace P03_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region DataTypes
            //C# 'ta veri tipleri çok önemlidir.çeşitli veri tiplerş bulunmaktadır.Özellikle sayılar ve sayı olmayanlar şeklinde inceliemek iyi olackatır. 

            //Tam Sayılar;
            //byte sayi1 = 255;
            //sbyte sayi2 = 15;
            //Console.WriteLine(sayi1+"sayısının alabileceği minimum değer: "+ byte.MinValue);
            // Console.WriteLine(sayi1 + "sayısının alabileceği max değer: " + byte.MaxValue);
            //Console.WriteLine(sayi1 + "sayısının bellekte kapladığı alan : " + sizeof(byte) +"byte");
            /*       byte sayi1 = 10;
                   ushort sayi2 = 10;
                   uint sayi3 = 40;
                   ulong sayi4 = 50;

                   sbyte sayi5 = -50;
                   short sayi6 = -6;
                   int sayi7 = -7;
                   long sayi8 = -8;
       */ // #endregion

            /*
                        #region ONDALIKLI SAYILAR
                        float sayi1 = 56.7F;
                        double sayi2 = 56.78;
                        decimal sayi3 = 76.665M;


                        Console.WriteLine(float.MinValue);
                        Console.WriteLine(float.MaxValue);
                        Console.WriteLine(sizeof(float) + "byte");
                        Console.WriteLine(sayi1.GetType());
                        Console.WriteLine();


                        Console.WriteLine(double.MinValue);
                        Console.WriteLine(double.MaxValue);
                        Console.WriteLine(sizeof(double) + "byte");
                        Console.WriteLine(sayi2.GetType());
                        Console.WriteLine();
                        Console.WriteLine(decimal.MinValue);
                        Console.WriteLine(decimal.MaxValue);
                        Console.WriteLine(sizeof(decimal) + "byte");
                        Console.WriteLine(sayi3.GetType());


            */


            // #endregion
            /* #region METİN VE KARAKTERLER
             char answer = 'A';
             string name = "Ali Veli";
             Console.WriteLine(answer + "tipi: "+ answer.GetType()+ "-Min: "+ char.MinValue );
             Console.WriteLine(name[4]);


             #endregion



 */
            /*
                        #region MANTIKSAL
                        bool isActive = true;
                        Console.WriteLine(isActive);

                        #region
            */

            #region TARİH SAAT
            //işlem yapabilmek amacıyla
            //tanımlarken önce tipni yazmak gerekiyor
            DateTime birthDay = new DateTime(1999, 3, 7);
            Console.WriteLine(birthDay);

            #endregion

            Console.ReadLine();






           
        }
    }
}

