using P06_Static.Helper;
namespace P06_Static
{
    public static class Deneme
    {
        public static int Sayi { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string name = "Alex?de?Souza";
            /*  HelperMethods helper = new HelperMethods();
              Console.WriteLine(helper.EditText(name);*/
            Console.WriteLine(HelperMethods.EditText(name));

            Console.ReadLine();
        }
    }
}

//Çok eksikk