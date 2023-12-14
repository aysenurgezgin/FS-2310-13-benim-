using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace P09_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Intro
            /* Console.WriteLine("Yaş: ");
             int yas = int.Parse(Console.ReadLine());
             if (yas >= 18) ;
             {
                 Console.WriteLine("Giriş yapabilirisniz");
             }
             else
             {
                 Console.WriteLine("Giremezsiniz!");
             } eksikk*/
            #endregion


            #region Tek satırlık If
            /*    if(false) Console.WriteLine("Doğru");
                Console.WriteLine("Bitti..");*/
            #endregion

            #region If-ElseIf
            /*  int age = 45;
              if (age < 18)
              {
                  Console.WriteLine("Çocuk");
              }
              else if (age < 40) 
              {
                  Console.WriteLine("Genç");
              }
              else
              {
                  Console.WriteLine("Yaşlı");
              }*/

            #endregion

            #region TurneryIf
            //int age = 40;
            /* Console.WriteLine(age < 18 ? "Çocuk" : "Genç");*/
            /*      string message = age < 18 ? "Çocuk" : "Genç";
                  Console.WriteLine(message);*/
            #endregion


            #region SwitcCase bu kısm da eksikelrin var
         /*   int x = 25;
            switch
                tam  yazamadım hocaın reposundan çekersin)
            {
               
            }*/
            #endregion

            Console.ReadLine();
        }
    }
}