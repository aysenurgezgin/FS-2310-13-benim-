using static P04_Inheritance.Person;

namespace P04_Inheritance
{
    public  class Alive
    {
        public string Category { get; set; }
    }
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //eger bu metodun,miras alan sınıflarında yeniden yazılabilmesine izin vermek istiyorsak  virtual keywordş yazarız
        public  virtual void Intro()
        {
            Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName} ");
        }
        public class Student:Person
        {
            public int StudentNumber { get; set; }
        }
    }
    public class Teacher : Person
    {
        public string Branch { get; set; }
        public override void Intro()
        {
            Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}, Branch: {Branch}");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
          /*  Student student1 = new Student();
            Teacher teacher = new Teacher();
            teacher.FirstName = "Temel";
            teacher.LastName = "Suluk";
            teacher.Branch = "Fizik";
            teacher.Intro();*/
          Base nesne= new Base();
          Product product= new Product();

            Console.ReadLine();
        }
    }
}
  //bir clasın başka bir klasa aktarlmasıdır
  //based ve dileved miras alan miras vern : işareti ile 
  //birden fazla clasttan miras almamıza izin vermezm (polimorfizm=aynı davranışa sahip olan nesnelre o davranılraı faklı yapmalrı) çatışmaları önlemek adına 
  //bir class birden fazla miras verbilir ama bir clas birden fazla clas birden fazla clastan miras alamaz.

//overried etmek farklı davranışlar sergilemesi için 
//özetleme abstact   soyutlama temel bilgi vermek gibi syut method içinde kod bekleme somut yaptığı birşey 