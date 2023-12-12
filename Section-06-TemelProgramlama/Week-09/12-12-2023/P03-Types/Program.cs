namespace P03_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DataTypes
            //C# 'ta veri tipleri çok önemlidir.çeşitli veri tiplerş bulunmaktadır.Özellikle sayılar ve sayı olmayanlar şeklinde inceliemek iyi olackatır. 

            //Tam Sayılar;
            byte sayi1 = 255;
            sbyte sayi2 = 15;
            Console.WriteLine(sayi1+"sayısının alabileceği minimum değer: "+ byte.MinValue);
            Console.WriteLine(sayi1 + "sayısının alabileceği max değer: " + byte.MaxValue);
            Console.WriteLine(sayi1 + "sayısının bellekte kapladığı alan : " + sizeof(byte) +"byte");

            Console.WriteLine(sayi2 + "-" + sizeof(double)+ "byte");




            #endregion

            Console.ReadLine();
        }
    }
}

