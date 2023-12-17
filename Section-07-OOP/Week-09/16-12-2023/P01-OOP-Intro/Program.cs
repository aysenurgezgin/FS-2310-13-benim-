using System.Collections;

namespace P01_OOP_Intro
{
    public class Person
    {
        //Field
        private int age;
        public int Age
        {
            get{ return age; }
            set{ age=value; }
        }

        private string name;
        public string Name
        {
            get { return name.ToUpper(); }
            set { name=value.ToLower(); }
        }

        public bool IsStatus {
            get
            {
                if (age >= 25) return true;
                return false;
            } 
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList products = new ArrayList();
            string answer;
            do
            {
                Product product = new Product();
                Console.Write("Product Name: ");
                product.Name = Console.ReadLine();
                Console.Write("Product Description: ");
                product.Description = Console.ReadLine();
                Console.Write("Product Price: ");
                product.Price=decimal.Parse(Console.ReadLine());
                products.Add(product);
                Console.WriteLine();
                Console.Write("Yeni ürün girmek istiyor musunuz?(E/H): ");
                answer= Console.ReadLine();
            } while (answer=="E");
            foreach (Product product in products)
            {
                Console.WriteLine($"Name: {product.Name}\t\tDescription: {product.Description}\t\tPrice: {product.Price}");
            }










            //Person ece = new Person();
            //Person ayse=new Person();
            //Person haydar=new Person();

            //ece.Age = 22;
            //ece.Name = "ece";
            //ayse.Age = 20;
            //ayse.Name = "aYşENUR";
            //haydar.Age = 25;
            //haydar.Name = "HAYdar";


            //Console.WriteLine(ece.Name);
            //Console.WriteLine(ayse.Name);
            //Console.WriteLine(haydar.Name);

            //Console.WriteLine(ece.IsStatus);

            Console.ReadLine();
        }
    }
}
