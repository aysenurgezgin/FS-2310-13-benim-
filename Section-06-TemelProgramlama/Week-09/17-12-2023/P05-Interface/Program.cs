namespace P05_Interface
{
   
    public interface IPerson
       
    {

        public string Deparment { get; set; }

        public int Address { get; set;}
        public string City { get; set;}
        public void Info();
        
    }
    public interface IPersonal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
    public class Admin : IPerson, IPersonal
    {
        public string Deparment { get; set; }
        public int Address { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string SubDepartment { get;  set; }

        public void Info()
        {
            Console.WriteLine($"{City}-{SubDepartment}");
        }
    }
    public class Guest : IPersonal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
        public interface IEmployee : IPerson, IPersonal
        {
            public string SubDepartment { get; set; }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin();
            admin.City = "İstanbul";
            admin.Info();
            

          /*  Console.WriteLine(admin);*/
            Console.ReadLine();
        }
    }
}

//abstarct yapı :içinde hrhengi bir abstarc yapı kullanabilirsin calss abstt=soyut olması

//iplemente etmek (iplememek)
//interfce  herşey soyut diyor 
//throw uygulamayı kes hata yaomadığın halde hat
//a yapmış oluyorsun kontollü kaza yani
//


//Bir class sadece bi classtan miras alabilir
//Abstract class ya da Interface'den yeni bir nesne üretilemez(new yapılamaz)
/*Bir abstract class içinde hem soyut ,hem somut memberlar bulunabilir.
    Dolayısıypla bir abstact classa,hem soyut hemde somut memberlarımız varsa ihtiyaç duyarız.Eğer sadece soyut yapılara iht varsa Interface kullanırız.Yani bir Interface 
 içerindeki tüm memberlar soyuttur.
Eğer bir class hem interface hem de clasttan miras alacaksa önce class ismi yazılmak zorundadırö sonrasında birden fazla interface yazılarak implemente edilebilir.
*/