namespace P10For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Intro
            /*   for (int i = 0; i <10; i++)
               {
                   Console.WriteLine("Hello");
               }*/
            #endregion


            #region ForEach
            //burada döngü komutu ama jste gibi dizi gibi kulanıcaz(anahtar keşlime in)
            /*    string[] names = { "Ayşenur", "Zeynep", "Ece", "Ferda", "Murat" };
                foreach (string name in names) 
                {
                    Console.WriteLine(name);
                }
    */
            /*
                        int[] numbers = { 1, 2, 3, 4, 5 };
                        int[] newNumbers = new int[5];
                        int index = 0;

                        foreach (var number in numbers)
                        {
                            newNumbers[index] = number*2;
                            index++;
                        }*/


            //js yaptıklarını C# ta yapmaya çalış
            //Klavyeden girişlcek bir sayıya kadar olan sayıların içinden kaç tanesinin çift kaçtanesinin üçün katı sayı olduğunı buldurup konsola yazdıraalım



            Console.Write("Lütfen bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayi; i++) ;
            int ciftSayiAdedi = 0;
            int ucunKatiSayiAdedi = 0;
            for (int i = 0; i <= sayi; i++) ;
            {
                if (i % 2 == 0) ciftSayiAdedi++;
                if (i % 3 == 0) ucunKatiSayiAdedi++;

            }



            #endregion

            Console.ReadLine();
        }
    }
}