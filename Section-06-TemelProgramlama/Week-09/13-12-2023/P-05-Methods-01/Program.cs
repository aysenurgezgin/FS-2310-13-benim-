namespace P_05_Methods_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region StringMethods
            /*    string name = "Halil Umut Meler";*/
            /*     int len =name.Length;
                 Console.WriteLine(name + " metnin uzunluğu:" +len+*/
            /*   Console.WriteLine(name.ToUpper());
               Console.WriteLine(name.ToLower());*/

            /* string m1 = "Bahçehir";
             string m2 = "Üniversitesi";
             int year = 1996;
             Console.WriteLine(m1 + " " + m2);
             Console.WriteLine(String.Concat(m1, " ", m2));
             Console.WriteLine(m1 + " " + m2 + " " + year + " yılında kurulmuştur.");
             Console.WriteLine(String.Concat(m1, " ", m2, " ", year, " yılında kurulmuştur."));
             string result = $"{m1} {m2}";
             string result2=$"{m1} {m2} {year} yılında kurulmuştur.";

             Console.WriteLine(result);
             Console.WriteLine(result2);*/
            //metin birleştirme


            /*     string name = "Ece";
                 int age = 13;
                 string school = "Yeditepe 100";
                 string result = $"Ad: {name}\nYaş: {age}";
                 Console.WriteLine(result);
                 Console.WriteLine($"{name}
     */

            //yeni satıra gec \n
            //tab durak demek ve hepsi aynı mesafede olacaktır.
            /*
                        string courseName = "Fullstack Web Developer Eğitimi";
                        string findText = "web";
                        bool result = courseName.ToLower().Contains(findText.ToLower());
                        Console.WriteLine(result);
            */
            /*
                        string name = "Zeyno";
                        Console.WriteLine(name.IndexOf("y"));
                        Console.WriteLine(name.StartsWith("a"));
                        Console.WriteLine(name.EndsWith("o"));
            */
            //char nedir ona bir bak (9 farklı kullanım şekli var)=overload meselesi


            /*
                        string school = "Yeditepe İlköğretim Mektebi";
                        string result = school.Replace("Mektebi", "Okulu");
                        Console.WriteLine(result);*/

            /* string title = "C#'ta Metinsel İşlemler";
             Console.WriteLine(title.Replace(" ", "-").ToLower());
             string text = "Bugün hava çok güzeldi. Ama akşama doğru, have bozdu.";
             Console.WriteLine(text.Replace("a", ""));*/
            //replace çalışma mantığı olan çalışmalar



            //url oluşturma;
            string title = "Tesla, 2 milyon'dan fala aracı otopilot yazılımını güncellemek için geri çağıracak!";
            Console.WriteLine(title);
            title = title.ToLower();
            title = title.Replace(" ", "-");
            title = title.Replace(",", "");
            title = title.Replace("ı", "i");
            Console.WriteLine(title);

            //f5 




            #endregion


            Console.ReadLine();
        }
    }
}

//js fonk dediğimiz ieylre c# method diyor