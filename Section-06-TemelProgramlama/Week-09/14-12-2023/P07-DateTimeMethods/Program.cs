using System.Runtime.CompilerServices;

namespace P07_DateTimeMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*      DateTime birthDay = new DateTime(1999, 3, 7);
                  Console.WriteLine(birthDay.ToShortDateString());
                  Console.WriteLine(birthDay.ToLongDateString());

                  DateTime today = DateTime.Now;
                  Console.WriteLine(today.ToShortTimeString());*/

            //Gelecek yılın ilk gününün tarihini veren kod;

            /*  int year = DateTime.Now.Year +1;
              int month = 1;
              int day = 1;
              DateTime resaultDate = new DateTime(year, month, day);
              Console.WriteLine(); tam bitmedi*/


            //Tam bir yıl sonraki aynı günün tarihini bulduram kod;

            DateTime today = DateTime.Today;
            int year = today.Year + 1;
            int month = today.Month;
            int day = today.Day;
            DateTime resultDate = new DateTime(year, month, day);
            Console.WriteLine(resultDate.ToLongDateString());

            //Araştırma Ödevi: C#'ta tarihlerle ilgil yapılabilecek işlemleri araştırınız.



            Console.ReadLine();
        }
    }
}