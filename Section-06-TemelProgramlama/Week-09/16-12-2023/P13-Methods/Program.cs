namespace P13_Methods
{
    internal class Program
    {
        static void SelamVer()
        {
            Console.WriteLine("Günaydın!");
        }
        static int KacKelime(string metin)
        {
            string[] kelimeler = metin.Split(' ');
            return kelimeler.Length;
        }
        static int KelimeAdedi(string metin, string aranacakMetin, bool buyukKucuk)
        {
            if (!buyukKucuk)
            {
                metin = metin.ToLower();
                aranacakMetin = aranacakMetin.ToLower();
            }

            string[] kelimeler = metin.Split(' ');
            int adet = 0;
            foreach (string kelime in kelimeler)
            {
                if (kelime == aranacakMetin) adet++;
            }
            return adet;
        }
        static int[] SayiUret(int adet, int min, int max)
        {
            Random random = new Random();
            int[] sayilar = new int[adet];
            for (int i = 0; i < adet; i++)
            {
                sayilar[i]= random.Next(min, max);
            }
            return sayilar;
        }
        static int SesliHarfAdedi(string metin)
        {
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };
            char[] sessizHarfler = { 'b', 'c', 'd', 'g', 'k', 'l', 'm', 'n', 'r', 's', 't', 'v', 'y', 'z' };
            int sesliHarfAdedi = 0;
            metin = metin.ToLower();
            for (int i = 0; i<metin.Length; i++) 
            {
                if (sesliHarfler.Contains(metin[i]))
                {
                    sesliHarfAdedi++;
                }
                else if (sessizHarfler.Contains(metin[i]))
                {
                    /*sessizHarfAdedi++;*/
                }

            }

            return sesliHarfAdedi;
        }

        //içinde türkçe karakter bulundurmadan tüm küçük harfleri,0-9 arasındaki rakamları,nokta(.) işaretini, virgül(,) işaretini artı(+)işaretini ve eksi (-)işaretini barındırabilen, toplam uzunluğu 6 karakter olacak şekilde rastgele bir şifre üreten methodu yazınız
        static string SifreUret()
        {
            string karakterler = "abcdefghjklmnoprstuvyz0123456789.,+-";
            Random random = new Random();
            string sifre = "";
            for (int i = 0; i < 6; i++)
            {
                sifre += karakterler[random.Next(0, karakterler.Length)];
            }
            return sifre;
        }

        //Şİfre Üretme
        //1) Şifre mutlaka harfle başlamalı
        //2)Şifrenin içinde bir rakam olmalı.
        //3)Şifrenin iiçnde bir adet özel karakter (.,+-)olmalı
        //4)Kalan karakterler harf olmalı.
        //5)Şİfre uzunluğu 6 karakter olmalı
        //6)Büyük harf kullanılmamalı.

        static string SifreUret2();
        static void Main(string[] args)
        {
            Console.WriteLine(SifreUret2());
            {
                string karakterler = "abcdefghjklmnoprstuvyz0123456789.,+-";
                Random random = new Random();
                string sifre = "";
                for (int i = 0; i < 6; i++)
                {
                    sifre += karakterler[random.Next(0, karakterler.Length)];
                }
             

                string sayilar = "0,1,2,3,4,5,6,7,8,9";
                Random random = new Random();
                string sifre = "";
                for (int i = 0; i < 6; i++)
                {
                    sifre += sayilar[random.Next(0, sayilar.Length)];
                }
             
                string ozelKarakter = ".,,,+,-";
                Random random = new Random();
                string sifre = "";
                for (int i = 0; i < 6; i++)
                {
                    sifre += ozelKarakter[random.Next(0, ozelKarakter.Length)];
                }
                
            }return sifre;

            //int[] sayilar = SayiUret(100,1,501);
            //foreach (int sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}

            //int adet = KelimeAdedi("Bugün çok güzel. Çok mutluyum. Çok iyiyim.", "çok", false);
            //Console.WriteLine(adet);
            //SelamVer();
            //Console.Write("Bir cümle giriniz...: ");
            //string cumle = Console.ReadLine();  
            //int kelimeSayisi = KacKelime(cumle);
            //Console.WriteLine($"'{cumle}' cümlesindeki kelime sayısı: {kelimeSayisi}");

            Console.ReadLine();
        }
    }
}
