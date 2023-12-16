using System.Collections;

namespace P_01_OOP_Intro
{
   public class Person
    {
        //bilgi tutulacak alan =Field  (c# litaratüründe) propertyleri tanımlamayı caemel case pascal  cae ona bir bak(kısa yazma meselesi fieldi yazmamak)
        //şablon oluşturdum dedim./ methodlar yapılabicek özellikleri(özellik tanımlama=kapsülleme prensibi get ve setler)obje nesnelri kullanıcaz(ncapsulatin)(dışarı istediğimiz gibi akatrmayı sağlayacak)erişim belirleyici içinde axex privaty(bulunduğu yerde calışsın, ilgili değişkenin )(public her yerden erişilebilir)
        private int age;
        public int Age
        {
            get{ return age;}
            set{age = value;}   
            
        }
        private string name;
        public string Name
        {
            get { return name;} 
            set { name = value.ToLower();}
        }
       
        public bool IsStatus {
            get{
                if (age >= 25) return true;
                return false;
            } 
        }
    }
    public class Product
    {
        //prop yapıp tab tab yapmayı daha alışsın elin.
        public string Name  { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }


    }
    public class Program
    {
        static void Main(string[] args)
        {   ArrayList products = new ArrayList();
            string answer;
            do
            {
                Product product = new Product();
                Console.WriteLine("Product Name: ");
                product.Name = Console.ReadLine();
                Console.WriteLine("Product Description: ");
                product Description = Console.ReadLine();
                product.Price("Product Price: ");
                product.Price=decimal.Parse(Console.ReadLine());

                answer = Console.ReadLine();
            } while (answer=="E");
            foreach (Product product in products)
            {
                Console.WriteLine($"Name: {product.Name}\t\tDescription: {product.Description}\t\t{product.Price}");
            }






           /* Person ece = new Person();
            Person ayse = new Person();
            Person haydar= new Person();
            ece.Age = 30;
            ece.Name = "ece";
            ayse.Age = 20;
            ayse.Name = "aysENUR";
            haydar.Age = 25;
            haydar.Name = "Haydar";

            Console.WriteLine(ece.Name);
            Console.WriteLine(ayse.Name);
            Console.WriteLine(haydar.Name);

            Console.WriteLine(ece.IsStatus);*/

            //get i olup seti olmayan =length
            Console.ReadLine();

        }
    }
}